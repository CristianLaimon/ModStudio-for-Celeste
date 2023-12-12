using CelesteModStudioGUI.NewProjectForms;
using ModStudioLogic;
using ModStudioTesting;
using NewProjectGUI;

namespace FormsTesting
{
    internal static class Program
    {
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            SetupProject();
            Application.Run(new ModSetupForm());
        }

        private static void SetupProject()
        {
            ProjectManager.AddProject(TemplatesProjects.GetSimpleProject());
        }
    }
}