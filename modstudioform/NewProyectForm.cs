using ModStudioLogic;
using System.Reflection.Metadata;
using ModStudioLogic.Enums;
using ModStudioLogic.ModProject;
using ModStudioLogic.FormsLogic;

namespace ModStudio_for_Celeste
{
    public partial class NewProyectForm : Form
    {
        State _formState;
        private State FormState
        {
            get { return _formState; }
            set
            {
                _formState = value;
                UpdateStatusStringForm(_formState);
            }
        }
        public NewProyectForm()
        {
            InitializeComponent();
            InitialConfig();
        }
        private void InitialConfig()
        {
            this.CenterToScreen();
            FormState = State.Default;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void ChooseDirectory()
        {
            FormState = State.ChoosingDirectory;

            if (FileManager.ShowOpenDirectoryDialog(out string dir))
            {
                textBoxDirectorySelected.Text = dir;
            }

            FormState = State.Default;
        }
        private void GetModProject()
        {
            if (FormValidation.TextBoxesAreValid(this.Controls.OfType<TextBox>().ToArray()))
            {
                Project newProject = new Project();
                newProject.ParentDirPath = textBoxDirectorySelected.Text;
                newProject.ModVersion = "0.0.1";
                newProject.CampaignName = textBoxCampaignName.Text;
                newProject.ModName = textBoxModName.Text;
                newProject.ModAuthor = textBoxUsernameMod.Text;
                ProjectManager.AddProject(newProject);

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

            DirectoryInfo projectPath = Directory.CreateDirectory(Path.Combine(project.ParentDirPath, project.ModName));
            string dirPath = projectPath.FullName;

            Directory.CreateDirectory(Path.Combine(dirPath, project.))
        }
        private void UpdateStatusStringForm(State newState)
        {
            stripLabelActualStatus.Text = ModStudioState.GetMessageByState(newState);
        }

        #region FormEvents
        private void buttonSelectNewDirectory_Click(object sender, EventArgs e)
        {
            ChooseDirectory();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            GetModProject();
            CreateModFolders();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
