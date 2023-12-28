using CelesteModStudioGUI.Utils;
using ModStudioLogic;
using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;

namespace CelesteModStudioGUI
{
    //TODO: Close temp project opened when creating or opening a project, and avoid storing twice or more the same project in Projects Class
    //TODO:
    /*Open map with loenn editor
	    - Replace temp lastopen text to open new file with loenn
		    - Recognize if os have loenn installed
			    - installed with everest
			    - installed custom by user (get path by user)

			    if (Loenn != State.Installed)
				    Download Loenn separately (inside this project) */

    public partial class Main : Form
    {
        private IModStudioState? _formState;

        public Main()
        {
            InitializeComponent();
            SetupForm();
            SetupCache();
            Test();
            SetState(new FormStateStartup());
        }

        private void Test()
        {
            //tabControl1.TabPages.Clear();
            tabControl1.TabPages.RemoveAt(0);
            var tab = new TabPage("TextUp");
            tab.Name = "testing tab";
            tabControl1.TabPages.Add(tab);
            var usercon = new BaseTabControl();
            usercon.Name = "UserControl";
            usercon.Dock = DockStyle.Fill;

            tabControl1.TabPages["testing tab"].Controls.Add(usercon);
            //usercon.Show();
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

        private void loennMapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void treeViewFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Contains(".bin"))
            {
                //CLEAN THIS UP!!!!!!!!!!!!!!

                //to give the possibility to have multiple mods loaded!!
                //Get project full path
                //get actual project from this map selected
                //search in opened projects for the name and give the full path

                TreeNode root = GetRootNode(e.Node);
                Project proj = Projects.GetProjectByName(root.Text);

                Loenn.SetMapCacheOnLoenn(Path.Combine(
                    proj.FullPath,
                    "Maps",
                    proj.AuthorName,
                    proj.CampaignName,
                    e.Node.Text
                    ));

                Loenn.Launch();
                //recursively get project name
            }
        }

        private TreeNode GetRootNode(TreeNode node)
        {
            TreeNode pointer = node;

            while (pointer.Parent != null)
                pointer = pointer.Parent;

            return pointer;
        }
    }
}