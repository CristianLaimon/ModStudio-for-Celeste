using ModStudioLogic;
using ModStudioLogic.Mods;
using ModStudioLogic.FormsLogic;
using ModStudioWinForms;

namespace CelesteModStudioGUI
{
    public partial class NewProyectForm : Form
    {
        IModStudioState _formState;

        public NewProyectForm()
        {
            InitializeComponent();
            SetState(new FormStateDefault());
            CenterToScreen();
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private void AddProjectToManager()
        {
            if (FormValidation.TextBoxesAreValid(this.Controls.OfType<TextBox>().ToArray()))
            {
                using (var confirmationForm = new ConfirmationForm())
                {
                    DialogResult result = confirmationForm.ShowDialog();
                    if (result == DialogResult.Cancel)
                        return;
                }

                Project newProject = new Project();
                newProject.FullPath = Path.Combine(textBoxDirectorySelected.Text, textBoxModName.Text);
                newProject.ModVersion = "0.0.1";
                newProject.ModName = textBoxModName.Text;
                newProject.AuthorName = textBoxUsernameMod.Text;

                foreach (ModFeature m in GetFeaturesSelected())
                    newProject.Features.Add(m);

                ProjectManager.AddProject(newProject);
                CreateModFolders();

                DialogResult = DialogResult.OK;
            }
            else
            {
                stripLabelActualStatus.Text = "No valid input. Please try again";
            }
        }
        private void CreateModFolders()
        {
            Project project = ProjectManager.GetLastProjectAdded();
            FileManager.CreateSubDirsWithProject(project); //Working on it....
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

        #region FormEvents
        private void buttonSelectNewDirectory_Click(object sender, EventArgs e)
        {
            ChooseDirectory();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            AddProjectToManager();
            Project actualProj = ProjectManager.GetLastProjectAdded();

            foreach(ModFeature mf in actualProj.Features)
            {
                NewProjectManager.Add(mf.form);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region Utilities
        private void SetState(IModStudioState newState)
        {
            _formState = newState;
            stripLabelActualStatus.Text = StateFormat.GetFormattedMessage(newState);
        }

        #endregion

    }
}
