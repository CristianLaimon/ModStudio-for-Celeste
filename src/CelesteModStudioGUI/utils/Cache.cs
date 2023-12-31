﻿using ModStudioLogic.ProjectInside;
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
            CacheFolderChecking();

            using (StreamWriter stream = new StreamWriter("utils\\last_project.txt"))
            {
                stream.WriteLine(projFullPath);
            }
        }

        internal static bool TryGetLastProject(out string? projFullPath)
        {
            CacheFolderChecking();

            using (StreamReader stream = new StreamReader("utils\\last_project.txt"))
            {
                projFullPath = stream.ReadLine();
            }

            return projFullPath != null && Directory.Exists(projFullPath);
        }

        private static void CacheFolderChecking()
        {
            //Brief Checking
            if (!Directory.Exists("utils"))
                Directory.CreateDirectory("utils");

            if (!File.Exists("utils\\last_project.txt"))
                File.Create("utils\\last_project.txt");
        }
    }
}