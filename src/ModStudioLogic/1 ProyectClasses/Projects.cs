namespace ModStudioLogic.ProjectInside
{
    public class Projects
    {
        private static List<Project> _openedProjects = new List<Project>();
        public static Project ActualProject;

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

        public static bool RemoveProject(Project project)
        {
            bool success = _openedProjects.Remove(project);

            if (success && ActualProject == project)
                ActualProject = null;

            return success;
        }

        public static Project GetProjectByName(string name)
        {
            Project? found = _openedProjects.Find(p => p.ModName == name);

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

        //static one?....
        public static bool CheckIfHasFeature(Project actual, Type type)
        {
            return actual.Features.Any(x => x.GetType() == type);
        }
    }
}