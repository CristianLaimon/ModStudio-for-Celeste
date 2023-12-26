using ModStudioLogic.BigClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModStudioLogic
{
    public class Loenn
    {
        private static string extension = ".bin";

        public static void CreateNewMap(string fullParentFolder, string nameMap)
        {
            File.Copy(Consts.LoennMapFile, Path.Combine(fullParentFolder, nameMap + extension));
        }
    }
}