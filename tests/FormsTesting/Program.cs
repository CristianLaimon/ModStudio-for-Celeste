using CelesteModStudioGUI;
using ModStudioLogic.ProjectInside;
using ModStudioTesting;

namespace FormsTesting
{
    internal static class Program
    {
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Projects.AddProject(TemplatesProjects.GetSimpleProject());
            //Application.Run(new ModSetupForm());
            Application.Run(new Main());
        }

        private static void SetupProject()
        {
            SetupProject();
        }
    }
}