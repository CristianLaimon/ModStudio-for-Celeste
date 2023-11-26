using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModStudioLogic.ModProject
{
    public class ProjectManager
    {
        private static List<Project> _openedProjects = new List<Project>();

        public static void AddProject(Project project)
        {
            _openedProjects.Add(project);
        }

        public static void RemoveProject(Project project)
        {
            _openedProjects.Remove(project);
        }

        public static Project GetProjectByPath(string projectPath)
        {
            Project? found = _openedProjects.Find(p => p.ParentDirPath == projectPath);

            return found == null ? new Project() : found;
        }

        public static Project GetLastProjectAdded()
        {
            return _openedProjects.Last();
        }
    }

}