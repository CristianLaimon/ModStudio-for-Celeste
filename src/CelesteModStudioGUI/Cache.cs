﻿using ModStudioLogic.ProjectInside;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModStudioLogic
{
    internal class Cache
    {
        internal static void SaveLastProject(Project proj)
        {
            SetCacheFolder();

            using (StreamWriter stream = new StreamWriter("utils\\last_project.txt"))
            {
                stream.WriteLine(proj.FullPath);
            }
        }

        internal static bool TryGetLastProject(out string projFullPath)
        {
            SetCacheFolder();

            using (StreamReader stream = new StreamReader("utils\\last_project.txt"))
            {
                projFullPath = stream.ReadLine();
            }

            return projFullPath == String.Empty;
        }

        private static void SetCacheFolder()
        {
            //Brief Checking
            if (!Directory.Exists("utils"))
            {
                Directory.CreateDirectory("utils");

                if (!File.Exists("last_project.txt"))
                {
                    File.Create("last_project.txt");
                }
            }
        }
    }
}