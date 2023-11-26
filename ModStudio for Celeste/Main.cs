using ModStudioLogic;

//https://www.reddit.com/r/celestegame/comments/e82ncn/madeline_fanart/ logo.png idea!, TODO:try to find original author...

namespace ModStudio_for_Celeste
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitialConfig();
        }

        private void InitialConfig()
        {
            this.CenterToScreen();
        }

        private void openExistingProyectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileManager.TryOpenNewDirectory(out string dir))
            {
                ProjectData.ProyectPath = dir;
            }
        }

        private void createNewModProyectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var newProyectForm = new NewProyectForm();
            newProyectForm.ShowDialog();
        }
    }
}
