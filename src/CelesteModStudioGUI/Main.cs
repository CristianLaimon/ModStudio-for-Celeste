using ModStudioLogic;
using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
using System.CodeDom.Compiler;
using System.Xml.Linq;

//https://www.reddit.com/r/celestegame/comments/e82ncn/madeline_fanart/ logo.png idea!, TODO:try to find original author...
//Probably are better ways to implement state pattern, i just wanna learn to use polymorphism. It's curious

//En base a los features elegidos, poner su correspondiente form de configuración
//hacer que el método de añadir features a proyecto sea "params Feature[]" y acepte cualquier cantidad. "Comodidad"
//Hacer que el visual studio pueda agrupar los #regions con el atajo para hacer fold a los métodos. ay dios, que enfadoso
namespace CelesteModStudioGUI
{
    //Hacer que se pueda cerrar la conexión con un projecto abierto (eliminarlo de ProjectManager)
    public partial class Main : Form
    {
        private IModStudioState? _formState;

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
                Project opened = new Project();
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
                Project tempLast = Projects.LastProject;
                LoadDirTree(tempLast.FullPath);
                SetState(new FormStateCustomMessage("Project " + tempLast.ModName + " Version: " + tempLast.ModVersion.ToString() + " created"));
            }
            else
            {
                SetState(new FormStateCustomMessage("Canceled Project"));
            }
        }

        private byte GetImageByExtension(string extension)
        {
            switch (extension)
            {
                case ".yaml":
                    return (byte)ModStudioImage.Mountain; //Mountain.png

                case ".dat":
                    return (byte)ModStudioImage.GreenGem;

                default:
                    return (byte)ModStudioImage.DefaultFile;
            }
        }

        private void SetState(IModStudioState newState)
        {
            _formState = newState;
            toolStripStatusLabelStatus.Text = StateFormat.GetFormattedMessage(_formState);
        }

        #region TreeDir

        private void LoadDirTree(string directory)
        {
            treeViewFiles.Nodes.Clear();

            TreeNode father = new(Projects.LastProject.ModName);
            LoadRecursive(father, Directory.GetDirectories(directory), Directory.GetFiles(directory));

            treeViewFiles.Nodes.Add(father);
        }

        private void LoadRecursive(TreeNode node, string[] dirPaths, string[] filePaths)
        {
            foreach (string path in dirPaths)
            {
                TreeNode childNode = new TreeNode(Path.GetFileName(path));
                childNode.ImageIndex = (byte)ModStudioImage.Folder;
                childNode.SelectedImageIndex = childNode.ImageIndex;

                string[] subDirs = Directory.GetDirectories(path);
                string[] subFiles = Directory.GetFiles(path);

                LoadRecursive(childNode, subDirs, subFiles);

                node.Nodes.Add(childNode);
            }

            foreach (string path in filePaths)
            {
                TreeNode childNode = new TreeNode(Path.GetFileName(path));
                childNode.ImageIndex = GetImageByExtension(Path.GetExtension(path));
                childNode.SelectedImageIndex = childNode.ImageIndex;

                node.Nodes.Add(childNode);
            }
        }

        #endregion TreeDir

        #region FormEvents

        private void openExistingProyectToolStripMenuItem_Click(object sender, EventArgs e) => OpenProject();

        private void createNewModProyectToolStripMenuItem1_Click(object sender, EventArgs e) => CreateProject();

        #endregion FormEvents
    }
}