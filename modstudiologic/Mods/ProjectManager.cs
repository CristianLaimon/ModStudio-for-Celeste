namespace ModStudioLogic.Mods
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
            Project? found = _openedProjects.Find(p => p.FullPath == projectPath);

            return found == null ? new Project() : found;
        }

        public static Project GetLastProjectAdded()
        {
            return _openedProjects.Last();
        }

    }
}