using System.Windows.Forms;

namespace ModStudioLogic
{
    public class FileManager
    {
        /// <summary>
        /// Opens a directory and returns the directory selected. 
        /// </summary>
        /// <returns>True if it success with a string of the new path otherwise false and ""</returns>
        public static bool TryOpenNewDirectory(out string openedDirectoryPath)
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
            string[] directoryFiles = Directory.GetFiles(directoryPath, "everest.yaml");
            return directoryFiles.Any() ? true : false;
        }
    }
}
