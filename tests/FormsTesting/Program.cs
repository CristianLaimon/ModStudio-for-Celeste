using CelesteModStudioGUI;
using CelesteModStudioGUI.NewProjectForms;
using CelesteModStudioGUI.TabControls;
using ModStudioLogic.ProjectInside;
using ModStudioTesting;

namespace FormsTesting
{
    internal static class Program
    {
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            //Application.Run(new Main());
        }

        private static void ModSetupTesting()
        {
            Projects.AddProject(TemplatesProjects.GetSimpleProject());
            Application.Run(new ModSetupForm());
        }
    }
}