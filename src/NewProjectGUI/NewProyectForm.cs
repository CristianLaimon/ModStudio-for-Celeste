using CelesteModStudioGUI.NewProjectForms;
using ModStudioLogic;
using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
using ModStudioLogic.ProyectInside;
using NewProjectGUI;
using NewProjectGUI.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Version = ModStudioLogic.Version;

//Some config are disabled due to they're not implemented yet...
namespace CelesteModStudioGUI
{
    public partial class NewProyectForm : Form
    {
        private IModStudioState _formState;
        private Project _proj;

        public NewProyectForm()
        {
            InitializeComponent();
            SetupThisForm();
        }

        #region Setup

        private void SetupThisForm()
        {
            SetState(new FormStateDefault());
            CenterToScreen();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        #endregion Setup

        #region Ok

        private void buttonOk_Click(object sender, EventArgs e) => OKLogic();

        private void OKLogic()
        {
            if (TryGetProjectFromForm(out Project proj))
            {
                _proj = proj;

                if (AreThereModFeatures(_proj))
                {
                    if (CheckConfigFormsConfirm() && CheckIfConfirmationOK())
                    {
                        FileManager.CreateSubDirsWithProject(_proj);
                        this.DialogResult = DialogResult.OK;
                        Projects.AddProject(_proj);
                        Projects.ActualProject = _proj;
                        this.Close();
                        this.Dispose();
                    }
                    //Dont add that project here (if project has mods but user doesnt complete mods config)
                }
                else
                {
                    Projects.AddProject(_proj);
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

        private bool AreThereModFeatures(Project proj) => proj.Features.Any();

        private bool CheckConfigFormsConfirm()
        {
            bool completedConfig = false;
            ChildMultiWindow[] forms = FormFabric.GetFeatureSettingForms(_proj);

            using (var setupForm = new MultiWindow(forms))
                completedConfig = setupForm.ShowDialog() == DialogResult.OK;

            return completedConfig;
        }

        private bool CheckIfConfirmationOK()
        {
            using (Form confirmationForm = new ConfirmationForm())
            {
                return confirmationForm.ShowDialog() == DialogResult.OK;
            }
        }

        private void SetState(IModStudioState newState)
        {
            _formState = newState;
            stripLabelActualStatus.Text = StateFormat.GetFormattedMessage(newState);
        }

        #endregion Ok

        #region Cancel

        private void buttonCancel_Click(object sender, EventArgs e) => CancelLogic();

        private void CancelLogic() => DialogResult = DialogResult.Cancel;

        #endregion Cancel

        #region ChooseDirectory

        private void buttonSelectNewDirectory_Click(object sender, EventArgs e) => ChooseDirectory();

        private void ChooseDirectory()
        {
            SetState(new FormStateChoosingDirectory());

            if (FileManager.ShowOpenDirectoryDialog(out string dir))
            {
                textBoxDirectorySelected.Text = dir;
            }

            SetState(new FormStateDefault());
        }

        #endregion ChooseDirectory
    }
}