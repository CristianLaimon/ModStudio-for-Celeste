using ModStudioLogic;
using ModStudioLogic.ModManagers;
using ModStudioLogic.FormsLogic;

namespace ModStudio_for_Celeste
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
        private void GetModProject()
        {
            if (FormValidation.TextBoxesAreValid(this.Controls.OfType<TextBox>().ToArray()))
            {
                ModProject newProject = new ModProject();
                newProject.ParentDirPath = textBoxDirectorySelected.Text;
                newProject.Version = "0.0.1";
                newProject.CampaignName = textBoxCampaignName.Text;
                newProject.Name = textBoxModName.Text;
                newProject.Author = textBoxUsernameMod.Text;
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
            ModProject project = ProjectManager.GetLastProjectAdded();

            DirectoryInfo projectPath = Directory.CreateDirectory(Path.Combine(project.ParentDirPath, project.Name));
            string dirPath = projectPath.FullName;

            //Directory.CreateDirectory(Path.Combine(dirPath, project.))
        }

        #region FormEvents
        private void buttonSelectNewDirectory_Click(object sender, EventArgs e)
        {
            ChooseDirectory();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            GetModProject();
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
