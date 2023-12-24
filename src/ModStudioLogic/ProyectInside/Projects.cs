namespace ModStudioLogic.ProjectInside
{
    public class Projects
    {
        private static List<Project> _openedProjects = new List<Project>();

        public static Project LastProject
        { get { return _openedProjects.Last(); } }

        public static int Count
        {
            get { return _openedProjects.Count; }
        }

        public static bool Exists(Project project)
        {
            return _openedProjects.Contains(project);
        }

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
            Project? found = _openedProjects.Find(p => p.FullPath == projectPath);

            return found == null ? new Project() : found;
        }

        public static Project GetLastProjectAdded()
        {
            return _openedProjects.Last();
        }

        public static void RemoveLastProject()
        {
            _openedProjects.Remove(_openedProjects.Last());
        }
    }
}