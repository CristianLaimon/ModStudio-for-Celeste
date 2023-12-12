using CelesteModStudioGUI.NewProjectForms;
using ModStudioLogic;
using ModStudioLogic.BigClasses;

namespace CelesteModStudioGUI
{
    public partial class NewProyectForm : Form
    {
        private IModStudioState _formState;

        public NewProyectForm()
        {
            InitializeComponent();
            SetState(new FormStateDefault());
            CenterToScreen();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void OKLogic()
        {
            if (TryGetProjectFromForm(out Project OutProject))
            {
                ProjectManager.AddProject(OutProject);

                if (OutProject.Features.Any())
                {
                    Form setupForm = new ModSetupForm();
                    setupForm.ShowDialog();
                }

                Form confirmationForm = new ConfirmationForm();
                DialogResult result = confirmationForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CreateModFolders(); //Pending
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    ProjectManager.RemoveLastProject();
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
            if (FormValidation.TextBoxesAreValid(this.Controls.OfType<TextBox>().ToArray()))
            {
                Project newProject = new Project();
                newProject.FullPath = Path.Combine(textBoxDirectorySelected.Text, textBoxModName.Text);
                newProject.ModVersion = new ModStudioLogic.Version(0, 1, 0);
                newProject.ModName = textBoxModName.Text;
                newProject.AuthorName = textBoxUsernameMod.Text;

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

        private void buttonSelectNewDirectory_Click(object sender, EventArgs e)
        {
            ChooseDirectory();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            OKLogic();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelLogic();
        }

        #endregion FormEvents

        #region Utilities

        private void SetState(IModStudioState newState)
        {
            _formState = newState;
            stripLabelActualStatus.Text = StateFormat.GetFormattedMessage(newState);
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
            Project project = ProjectManager.GetLastProjectAdded();
            FileManager.CreateSubDirsWithProject(project);
        }

        #endregion Utilities
    }
}