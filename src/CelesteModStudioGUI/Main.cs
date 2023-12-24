using CelesteModStudioGUI.utils;
using ModStudioLogic;
using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;

namespace CelesteModStudioGUI
{
    //TODO: Close temp project opened when creating or opening a project, and avoid storing twice or more the same project in Projects Class
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
                childNode.ImageIndex = ModStudio.GetImageByExtension(Path.GetExtension(path));
                childNode.SelectedImageIndex = childNode.ImageIndex;

                node.Nodes.Add(childNode);
            }
        }

        #endregion TreeDir
    }
}