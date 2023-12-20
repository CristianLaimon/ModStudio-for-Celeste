using ModStudioLogic;
using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;

//https://www.reddit.com/r/celestegame/comments/e82ncn/madeline_fanart/ logo.png idea!, TODO:try to find original author...
//Probably are better ways to implement state pattern, i just wanna learn to use polymorphism. It's curious

//TODO: Make UnitTesting of all this methods
//En base a los features elegidos, poner su correspondiente form de configuraci�n
//hacer que el m�todo de a�adir features a proyecto sea "params Feature[]" y acepte cualquier cantidad. "Comodidad"
//Hacer que el visual studio pueda agrupar los #regions con el atajo para hacer fold a los m�todos. ay dios, que enfadoso
namespace CelesteModStudioGUI
{
    //Hacer que se pueda cerrar la conexi�n con un projecto abierto (eliminarlo de ProjectManager)
    public partial class Main : Form
    {
        private IModStudioState _formState;

        public Main()
        {
            InitializeComponent();
            SetState(new FormStateStartup());
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        //Pending
        private void OpenProject()
        {
            SetState(new FormStateChoosingDirectory());
            if (FileManager.ShowOpenDirectoryDialog(out string dir) && FileManager.IsValidModProyect(dir))
            {
                Proyect opened = new Proyect();
                opened.FullPath = dir;
                Projects.AddProject(opened);
                LoadDirTree(opened.FullPath);
                //message form: "proyect" loaded
                SetState(new FormStateDefault());
            }
            else
            {
                SetState(new FormStateError("Error: Opened Project is not a celeste mod or valid directory to work with"));
            }
        }

        private void CreateProject()
        {
            SetState(new FormStateCreatingProject());
            var newProyectForm = new NewProyectForm();
            DialogResult result = newProyectForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Proyect tempLast = Projects.LastProject;
                LoadDirTree(tempLast.FullPath);
                SetState(new FormStateCustomMessage("Project " + tempLast.ModName + " Version: " + tempLast.ModVersion.ToString() + " created"));
            }
            else
            {
                SetState(new FormStateCustomMessage("Canceled Project"));
            }
        }

        private void LoadDirTree(string directory)
        {
            treeViewFiles.Nodes.Clear();
            LoadNodes(treeViewFiles, directory);
        }

        private void LoadNodes(TreeView tree, string directory)
        {
            tree.Nodes.Clear();
            string[] paths = Directory.GetDirectories(directory);
            string[] files = Directory.GetFiles(directory);

            foreach (string path in paths)
            {
                TreeNode node = new TreeNode(Path.GetFileName(path));
                LoadRecursive(node, Directory.GetDirectories(Path.GetFullPath(path)));
                tree.Nodes.Add(node);
            }

            foreach (string path in files)
                tree.Nodes.Add(Path.GetFileName(path));
        }

        private void LoadRecursive(TreeNode node, string[] paths)
        {
            foreach (string path in paths)
            {
                TreeNode childNode = new TreeNode(Path.GetFileName(path));
                LoadRecursive(childNode, Directory.GetDirectories(Path.GetFullPath(path)));
                node.Nodes.Add(childNode);
            }
        }

        #region FormEvents

        private void openExistingProyectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProject();
        }

        private void createNewModProyectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateProject();
        }

        #endregion FormEvents

        #region Utilities

        private void SetState(IModStudioState newState)
        {
            _formState = newState;
            toolStripStatusLabelStatus.Text = StateFormat.GetFormattedMessage(_formState);
        }

        #endregion Utilities
    }
}