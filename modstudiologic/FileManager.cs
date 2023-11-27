using ModStudioLogic.Mods;
using System.Windows.Forms;

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
        /// Get all data related to project: ModName, Author... from directory mod. This store that info into GlobalProyect class (temp info)
        /// </summary>
        /// <returns>True if operation sucess otherwise false</returns>
        //public static bool GetProjectDataFromDirectory(string directoryPath)
        //{
        //    if (!Directory.Exists(directoryPath) || !IsValidModProyect(directoryPath))
        //        return false;
        //}

        public static void CreateSubDirsWithProject(Project project)
        {
            DirectoryInfo modFolderPath =  Directory.CreateDirectory(Path.Combine(project.ParentDirPath, project.Name));
            
            foreach(ModFeature modf in project.Features)
            {
                Directory.CreateDirectory(Path.Combine(modFolderPath.FullName, modf.FolderName));
            }

        }
    }
}
