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
            Projects.AddProject(TemplatesProjects.GetSimpleProject());
            Application.Run(new ModSetupForm());
        }

        private static void SetupProject()
        {
            SetupProject();
        }
    }
}