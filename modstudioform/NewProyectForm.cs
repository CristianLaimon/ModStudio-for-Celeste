using ModStudio_Logic;
using System.Reflection.Metadata;
using ModStudio_Logic.Enums;
using ModStudio_Logic.ModProject;
using ModStudio_Logic.FormsLogic;

namespace ModStudio_for_Celeste
{
    public partial class NewProyectForm : Form
    {
        IModStudioState _formState;
        private IModStudioState FormState
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
            FormState = new DefaultState();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void ChooseDirectory()
        {
            FormState = new ChoosingDirectory();

            if (FileManager.ShowOpenDirectoryDialog(out string dir))
            {
                textBoxDirectorySelected.Text = dir;
            }

            FormState = new DefaultState();
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
        private void UpdateStatusStringForm(IModStudioState newState)
        {
            stripLabelActualStatus.Text = StateFormat.GetFormattedMessage(newState);
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
