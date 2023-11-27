using ModStudio_Logic;
using IStates;
using ModStudio_Logic.ModProject;

//https://www.reddit.com/r/celestegame/comments/e82ncn/madeline_fanart/ logo.png idea!, TODO:try to find original author...

namespace ModStudio_for_Celeste
{
    public partial class Main : Form
    {
        IModStudioState _formState;

        public Main()
        {
            InitializeComponent();
            SetState(new FormStateStartup());
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void OpenNewProject()
        {
            SetState(new FormStateChoosingDirectory());
            if (FileManager.ShowOpenDirectoryDialog(out string dir) && FileManager.IsValidModProyect(dir))
            {
                ModProject opened = new ModProject();
                opened.ParentDirPath = dir;
                ProjectManager.AddProject(opened);
                SetState(new FormStateDefault());
            }
            else
            {
                SetState(new FormStateError("Error: Opened Project is not a celeste mod or valid directory to work with"));
            }
        }
        private void ShowNewProjectForm()
        {
            SetState(new FormStateDefault());
            var newProyectForm = new NewProyectForm();
            newProyectForm.ShowDialog();
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

        #region Utilities
        private void SetState(IModStudioState newState)
        {
            _formState = newState;
            toolStripStatusLabelStatus.Text = StateFormat.GetFormattedMessage(_formState);
        }

        #endregion
    }
}
