using CelesteModStudioGUI;
using CelesteModStudioGUI.Utils;
using ModStudioLogic;
using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
using System.Windows.Forms;

namespace CelesteModStudioGUI
{
    public partial class Main : Form
    {
        private IModStudioState? _formState;

        public Main()
        {
            InitializeComponent();
            SetupForm();
            SetupCache();
            SetState(new FormStateStartup());
        }

        #region Setup

        private void SetupForm()
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void SetupCache()
        {
            if (Cache.TryGetLastProject(out string lastFullPath))
                OpenProject(lastFullPath);
        }

        #endregion Setup

        #region Events

        private void createNewModButton(object sender, EventArgs e) => CreateProject();

        private void openExistingModButton(object sender, EventArgs e) => OpenProjWithDialog();

        private void OpenProjWithDialog()
        {
            if (FileManager.ShowOpenDirectoryDialog(out string asdf))
                OpenProject(asdf);
        }

        #endregion Events

        private void CreateProject()
        {
            SetState(new FormStateCreatingProject());

            var newProyectForm = new NewProyectForm();
            DialogResult result = newProyectForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Project last = Projects.LastProject;
                LoadDirTree(last.FullPath);
                Cache.SaveLastProject(last.FullPath);
                SetState(new FormStateCustomMessage("Project " + last.ModName + " Version: " + last.ModVersion.ToString() + " created"));
            }
            else
            {
                SetState(new FormStateCustomMessage("Canceled Project"));
            }
        }

        private void OpenProject(string dir)
        {
            SetState(new FormStateChoosingDirectory());

            if (FileManager.IsValidModProyect(dir))
            {
                Project opened = FileManager.GetProjectDataFromDirectory(dir);

                if (!Projects.Exists(opened))
                    Projects.AddProject(opened);

                Cache.SaveLastProject(opened.FullPath);
                LoadDirTree(opened.FullPath);
                SetState(new FormStateCustomMessage($"Opened: {opened.ModName}"));
            }
            else
                SetState(new FormStateError("Error: Opened Project is not a celeste mod or valid directory to work with"));
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
            father.ImageIndex = (int)ModStudioImage.RedStrawberry;
            father.SelectedImageIndex = father.ImageIndex;

            string[] dirs = Directory.GetDirectories(directory);
            string[] files = Directory.GetFiles(directory);
            LoadRecursive(father, dirs, files);

            treeViewFiles.Nodes.Add(father);

#if DEBUG
            treeViewFiles.ExpandAll();
#else
            father.Expand();
#endif
        }

        private void LoadRecursive(TreeNode node, string[] dirPaths, string[] filePaths)
        {
            foreach (string path in dirPaths)
            {
                TreeNode childNode = new TreeNode(Path.GetFileName(path));
                childNode.ImageIndex = (int)ModStudioImage.Folder;
                childNode.SelectedImageIndex = childNode.ImageIndex;

                string[] subDirs = Directory.GetDirectories(path);
                string[] subFiles = Directory.GetFiles(path);

                LoadRecursive(childNode, subDirs, subFiles);

                node.Nodes.Add(childNode);
            }

            foreach (string path in filePaths)
            {
                TreeNode childNode = new TreeNode(Path.GetFileName(path));
                childNode.ImageIndex = ModStudio.GetImageByExtension(Path.GetExtension(path));
                childNode.SelectedImageIndex = childNode.ImageIndex;

                node.Nodes.Add(childNode);
            }
        }

        #endregion TreeDir

        #region DoubleClickTreeView

        private void treeViewFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Contains(".bin"))
            {
                TreeNode rootProjectNode = GetRootNode(e.Node);
                Loenn.SetMapCacheOnLoenn(rootProjectNode.Text, e.Node.Text);
                Loenn.Launch();
            }
        }

        private TreeNode GetRootNode(TreeNode node)
        {
            TreeNode pointer = node;

            while (pointer.Parent != null)
                pointer = pointer.Parent;

            return pointer;
        }

        #endregion DoubleClickTreeView

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check if project has maps features
        }
    }
}

//private void Test()
//{
//    //tabControl1.TabPages.Clear();
//    tabControl1.TabPages.RemoveAt(0);
//    var tab = new TabPage("TextUp");
//    tab.Name = "testing tab";
//    tabControl1.TabPages.Add(tab);
//    var usercon = new BaseTabControl();
//    usercon.Name = "UserControl";
//    usercon.Dock = DockStyle.Fill;

//    tabControl1.TabPages["testing tab"].Controls.Add(usercon);
//    //usercon.Show();
//}