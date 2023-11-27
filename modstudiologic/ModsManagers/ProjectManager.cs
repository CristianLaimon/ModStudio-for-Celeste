﻿namespace ModStudioLogic.ModManagers
{
    public class ProjectManager
    {
        private static List<ModProject> _openedProjects = new List<ModProject>();

        public static void AddProject(ModProject project)
        {
            _openedProjects.Add(project);
        }

        public static void RemoveProject(ModProject project)
        {
            _openedProjects.Remove(project);
        }

        public static ModProject GetProjectByPath(string projectPath)
        {
            ModProject? found = _openedProjects.Find(p => p.ParentDirPath == projectPath);

            return found == null ? new ModProject() : found;
        }

        public static ModProject GetLastProjectAdded()
        {
            return _openedProjects.Last();
        }
    }
}