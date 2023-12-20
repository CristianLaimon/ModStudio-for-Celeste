namespace ModStudioLogic.ProjectInside
{
    public class Projects
    {
        private static List<Proyect> _openedProjects = new List<Proyect>();

        public static Proyect LastProject
        { get { return _openedProjects.Last(); } }

        public static int Count
        {
            get { return _openedProjects.Count; }
        }

        public static void AddProject(Proyect project)
        {
            _openedProjects.Add(project);
        }

        public static void RemoveProject(Proyect project)
        {
            _openedProjects.Remove(project);
        }

        public static Proyect GetProjectByPath(string projectPath)
        {
            Proyect? found = _openedProjects.Find(p => p.FullPath == projectPath);

            return found == null ? new Proyect() : found;
        }

        public static Proyect GetLastProjectAdded()
        {
            return _openedProjects.Last();
        }

        public static void RemoveLastProject()
        {
            _openedProjects.Remove(_openedProjects.Last());
        }
    }
}