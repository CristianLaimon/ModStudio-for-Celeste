using ModStudioLogic;
using ModStudioLogic.Enums;
using ModStudioLogic.ModProject;

//https://www.reddit.com/r/celestegame/comments/e82ncn/madeline_fanart/ logo.png idea!, TODO:try to find original author...

namespace ModStudio_for_Celeste
{
    public partial class Main : Form
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
        public Main()
        {
            InitializeComponent();
            InitialConfig();
        }

        private void InitialConfig()
        {
            FormState = State.Startup;
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void ShowNewProjectForm()
        {
            var newProyectForm = new NewProyectForm();
            DialogResult result = newProyectForm.ShowDialog();
        }
        private void OpenNewProject()
        {
            FormState = State.ChoosingDirectory;
            if (FileManager.ShowOpenDirectoryDialog(out string dir) && FileManager.IsValidModProyect(dir))
            {
                Project opened = new Project();
                opened.ParentDirPath = dir;
                ProjectManager.AddProject(opened);
                FormState = State.Default;
            }
            else
            {
                toolStripStatusLabelStatus.Text = "Error: Opened Project is not a celeste mod or valid directory to work with";
            }
        }
        private void UpdateStatusStringForm(State newState)
        {
            toolStripStatusLabelStatus.Text = ModStudioState.GetMessageByState(newState);
        }

        #region FormEvents
        private void openExistingProyectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewProject();
        }
        private void createNewModProyectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowNewProjectForm();
        }
        #endregion
    }
}
