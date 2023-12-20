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
            //TODO: Check if has a valid mod structure... subfolders and that stuff
            string[] directoryFiles = Directory.GetFiles(directoryPath, "everest.yaml");
            return directoryFiles.Any() ? true : false;
        }

        /// <summary>
        /// Get all data related to project: ModName, Author... from directory mod. This store that
        /// info into project manager class (temp info)
        /// </summary>
        /// <returns>True if operation sucess otherwise false</returns>
        //public static bool GetProjectDataFromDirectory(string directoryPath)
        //{
        //    if (!Directory.Exists(directoryPath) || !IsValidModProyect(directoryPath))
        //        return false;
        //}

        public static void CreateSubDirsWithProject(Project project)
        {
            Directory.CreateDirectory(project.FullPath);
            File.Create(Path.Combine(project.FullPath, "everest.yaml")); //Make this a configurable window, mod object or just the file? .... i'll need to overwrite its contents over time

            foreach (ModFeature genericFeature in project.Features)
                genericFeature.CreateDirsAndFiles(project);
        }
    }
}