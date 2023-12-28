using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModStudioLogic.Olympus
{
    public class Olympus
    {
        private static string _olympusPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Olympus");

        public string EverestPath
        { set { _olympusPath = value; } }

        public static bool CheckIfInstalledDefault()
        {
            return Directory.Exists(_olympusPath);
        }
    }
}