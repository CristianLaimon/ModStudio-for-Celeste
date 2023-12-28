using ModStudioLogic.BigClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace ModStudioLogic
{
    public class Loenn
    {
        public const string LoennMapFile = "Loenn\\emptyLoennMap.bin";

        private static string extension = ".bin";

        private static string _parentPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Loenn");

        private static string _exePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Olympus", "loenn", "Lönn.exe");

        public static bool CheckIfInstalledDefault()
        {
            return Directory.Exists(_parentPath);
        }

        public static void CreateNewMap(string fullParentFolder, string nameMap)
        {
            File.Copy(LoennMapFile, Path.Combine(fullParentFolder, nameMap + extension));
        }

        public static void SetMapCacheOnLoenn(string fullMapPath)
        {
            string pathFormatted = fullMapPath.Replace("\\", "\\\\"); //Replace \ with \\

            string cachePath = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "Loenn",
                        "persistence.conf"
                        );

            string[] allLines = File.ReadAllLines(cachePath);
            for (int i = 0; i < allLines.Length; i++)
            {
                if (allLines[i].Contains("lastLoadedFilename"))
                {
                    allLines[i] = $"    lastLoadedFilename = \"{pathFormatted}\",";
                    break;
                }
            }
            File.WriteAllLines(cachePath, allLines);
        }

        public static void Launch()
        {
            Process.Start(_exePath);
        }
    }
}