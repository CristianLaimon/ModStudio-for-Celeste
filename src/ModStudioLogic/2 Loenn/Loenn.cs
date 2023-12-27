using ModStudioLogic.BigClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace ModStudioLogic
{
    public class Loenn
    {
        public const string LoennMapFile = "LoennTemplates\\emptyLoennMap.bin";

        private static string extension = ".bin";

        private static string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Loenn");

        public static bool CheckIfInstalledDefault()
        {
            return Directory.Exists(_path);
        }

        public static void CreateNewMap(string fullParentFolder, string nameMap)
        {
            File.Copy(LoennMapFile, Path.Combine(fullParentFolder, nameMap + extension));
        }
    }
}