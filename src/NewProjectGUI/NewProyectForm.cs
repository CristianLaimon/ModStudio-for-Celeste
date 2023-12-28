using CelesteModStudioGUI.NewProjectForms;
using ModStudioLogic;
using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
using ModStudioLogic.ProyectInside;
using Version = ModStudioLogic.Version;

//Some config are disabled due to they're not implemented yet...
namespace CelesteModStudioGUI
{
    public partial class NewProyectForm : Form
    {
        private IModStudioState _formState;

        public NewProyectForm()
        {
            InitializeComponent();
            SetupThisForm();
        }

        private void OKLogic()
        {
            if (TryGetProjectFromForm(out Project proj))
            {
                Projects.AddProject(proj);

                if (!AreThereModFeatures(proj))
                    return;

                if (CheckIfCompletesAllFeaturesConfig() && CheckIfConfirmationOK())
                {
                    CreateModFolders();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                SetState(new FormStateError("No valid input. Please try again"));
            }
        }

        private bool TryGetProjectFromForm(out Project OutProject)
        {
            //TODO: Get textboxes in order
            if (FormValidation.TextBoxesAreValid(textBoxModName, textBoxUsernameMod))
            {
                Project newProject = new Project();
                newProject.FullPath = Path.Combine(textBoxDirectorySelected.Text, textBoxModName.Text);
                newProject.ModVersion = new Version(0, 1, 0);
                newProject.ModName = textBoxModName.Text;
                newProject.AuthorName = textBoxUsernameMod.Text;
                newProject.Yaml = new EverestYaml(newProject.ModName, newProject.ModVersion);

                foreach (ModFeature m in GetFeaturesSelected())
                    newProject.Features.Add(m);

                OutProject = newProject;
                return true;
            }
            else
            {
                OutProject = null;
                return false;
            }
        }

        private void CancelLogic() => DialogResult = DialogResult.Cancel;

        #region FormEvents

        private void buttonSelectNewDirectory_Click(object sender, EventArgs e) => ChooseDirectory();

        private void buttonOk_Click(object sender, EventArgs e) => OKLogic();

        private void buttonCancel_Click(object sender, EventArgs e) => CancelLogic();

        #endregion FormEvents

        #region Utilities

        private void SetupThisForm()
        {
            SetState(new FormStateDefault());
            CenterToScreen();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void SetState(IModStudioState newState)
        {
            _formState = newState;
            stripLabelActualStatus.Text = StateFormat.GetFormattedMessage(newState);
        }

        private bool AreThereModFeatures(Project proj) => proj.Features.Any();

        private bool CheckIfConfirmationOK()
        {
            using (Form confirmationForm = new ConfirmationForm())
            {
                return confirmationForm.ShowDialog() == DialogResult.OK;
            }
        }

        private bool CheckIfCompletesAllFeaturesConfig()
        {
            using (Form setupForm = new ModSetupForm())
            {
                return setupForm.ShowDialog() == DialogResult.OK;
            }
        }

        private void ChooseDirectory()
        {
            SetState(new FormStateChoosingDirectory());

            if (FileManager.ShowOpenDirectoryDialog(out string dir))
            {
                textBoxDirectorySelected.Text = dir;
            }

            SetState(new FormStateDefault());
        }

        private ModFeature[] GetFeaturesSelected()
        {
            List<ModFeature> features = new List<ModFeature>();

            foreach (CheckBox ch in this.Controls.OfType<CheckBox>())
            {
                if (ch.Checked)
                    features.Add(ModFeatureFactory.GetFeatureByName(ch.Text));
            }

            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (CheckBox ch in groupBox.Controls.OfType<CheckBox>())
                {
                    if (ch.Checked)
                        features.Add(ModFeatureFactory.GetFeatureByName(ch.Text));
                }
            }

            return features.ToArray();
        }

        private void CreateModFolders()
        {
            Project project = Projects.GetLastProjectAdded();
            FileManager.CreateSubDirsWithProject(project);
        }

        #endregion Utilities
    }
}