using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
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
        public const string LoennMapFile = ".\\Loenn\\emptyLoennMap" + extension;

        public string ConfigPath
        { set { _configPath = value; } }

        public string ExePath
        { set { _exePath = value; } }

        private const string extension = ".bin";
        private static string _configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Loenn");
        private static string _exePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Olympus", "loenn", "Lönn.exe");
        private static string _cachePath = Path.Combine(_configPath, "persistence.conf");

        /// <summary>
        /// Method to tell Lönn to open a map file. This look for Lönn cache file (persistence.conf)
        /// on Cache Path stored (by default %appdata%\Loenn\persistence.conf)
        /// </summary>
        /// <param name="baseProjectName">Project Name where this maps comes from</param>
        /// <param name="mapName">Map Name to load</param>
        public static void SetMapCacheOnLoenn(string baseProjectName, string mapName)
        {
            Project proj = Projects.GetProjectByName(baseProjectName);

            string fullMapPath = Path.Combine(proj.FullPath, "Maps", proj.AuthorName, proj.CampaignName, mapName)
                            .Replace("\\", "\\\\");

            string[] allLines = File.ReadAllLines(_cachePath);
            for (int i = 0; i < allLines.Length; i++)
            {
                if (allLines[i].Contains("lastLoadedFilename"))
                {
                    allLines[i] = $"    lastLoadedFilename = \"{fullMapPath}\",";
                    break;
                }
            }
            File.WriteAllLines(_cachePath, allLines);
        }

        /// <summary>
        /// Pretty selfexplanatory. By default looks at "%%appdata%\Loenn" if exists
        /// </summary>
        /// <returns></returns>
        public static bool CheckIfInstalledDefault()
        {
            return Directory.Exists(_configPath);
        }

        /// <summary>
        /// Create a new template Lönn map copying it from ".\Loenn\emptyLoennMap.bin" of the
        /// compiled project to the desired location
        /// </summary>
        /// <param name="fullParentFolder">Parent folder to store the new map</param>
        /// <param name="nameMap">The new map name</param>
        public static void CreateNewMap(string fullParentFolder, string nameMap)
        {
            File.Copy(LoennMapFile, Path.Combine(fullParentFolder, nameMap + extension));
        }

        /// <summary>
        /// Execute Loenn program with the .exe path stored (By Default, looks for default path at "%appdata%\Olympus\loenn\Lönn.exe")
        /// </summary>
        public static void Launch()
        {
            Process.Start(_exePath);
        }
    }
}