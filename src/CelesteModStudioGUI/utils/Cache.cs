using ModStudioLogic.ProjectInside;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelesteModStudioGUI.Utils
{
    internal class Cache
    {
        internal static void SaveLastProject(string projFullPath)
        {
            SetCacheFolder();

            using (StreamWriter stream = new StreamWriter("utils\\last_project.txt"))
            {
                stream.WriteLine(projFullPath);
            }
        }

        internal static bool TryGetLastProject(out string? projFullPath)
        {
            SetCacheFolder();

            using (StreamReader stream = new StreamReader("utils\\last_project.txt"))
            {
                projFullPath = stream.ReadLine();
            }

            return projFullPath != null && File.Exists(projFullPath);
        }

        private static void SetCacheFolder()
        {
            //Brief Checking
            if (!Directory.Exists("utils"))
                Directory.CreateDirectory("utils");

            if (!File.Exists("utils\\last_project.txt"))
                File.Create("utils\\last_project.txt");
        }
    }
}