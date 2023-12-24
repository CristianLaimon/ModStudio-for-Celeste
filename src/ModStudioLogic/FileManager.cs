using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
using System.Windows.Forms;
using System.Xml;

namespace ModStudioLogic
{
    public class FileManager
    {
        /// <summary>
        /// Opens a directory and returns the directory selected.
        /// </summary>
        /// <returns>True if it success with a string of the new path otherwise false and ""</returns>
        public static bool ShowOpenDirectoryDialog(out string openedDirectoryPath)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.RootFolder = Environment.SpecialFolder.Desktop;

                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    openedDirectoryPath = folderDialog.SelectedPath;
                    return true;
                }
                else
                {
                    openedDirectoryPath = "";
                    return false;
                }
            }
        }

        /// <summary>
        /// Check if a directory is a mod directory. (Has everest.yaml metadata)
        /// </summary>
        /// <returns>True if it's a valid directory otherwise false</returns>
        public static bool IsValidModProyect(string directoryPath)
        {
            //TODO: Check if has a valid mod structure... subfolders and that stuff ...
            string[] directoryFiles = Directory.GetFiles(directoryPath, "everest.yaml");
            return directoryFiles.Any() ? true : false;
        }

        public static Project GetProjectDataFromDirectory(string directoryPath)
        {
            var openedProj = new Project();
            string[] rawDirs = Directory.GetDirectories(directoryPath);
            string[] dirs = new string[rawDirs.Length];

            for (int i = 0; i < rawDirs.Length; i++)
                dirs[i] = Path.GetFileName(rawDirs[i]);

            if (dirs.Contains("Maps"))
            {
                openedProj.Features.Add(new ModFeatureMaps());
                string[] insideDirs = Directory.GetDirectories(Path.Combine(directoryPath, "Maps"));

                openedProj.AuthorName = Path.GetFileName(insideDirs[0]);
            }

            if (dirs.Contains("Dialog"))
            {
                var dialogFeature = new ModFeatureDialog();
                string[] insideFiles = Directory.GetFiles(Path.Combine(directoryPath, "Dialog"));

                foreach (string file in insideFiles)
                {
                    string lang = Path.GetFileNameWithoutExtension(file);
                    dialogFeature.Languages.Add(lang);
                }
                openedProj.Features.Add(dialogFeature);
            }

            openedProj.FullPath = directoryPath;

            openedProj.ModName = Path.GetFileName(directoryPath);
            return openedProj;
        }

        public static void CreateSubDirsWithProject(Project project)
        {
            Directory.CreateDirectory(project.FullPath);
            File.Create(Path.Combine(project.FullPath, "everest.yaml")); //Make this a configurable window, mod object or just the file? .... i'll need to overwrite its contents over time

            foreach (ModFeature genericFeature in project.Features)
                genericFeature.CreateDirsAndFiles(project);
        }
    }
}