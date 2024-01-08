using CelesteModStudioGUI;
using CelesteModStudioGUI.NewProjectForms;
using CelesteModStudioGUI.TabControls;
using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
using ModStudioTesting;
using NewProjectGUI;
using NewProjectGUI.Forms;

namespace FormsTesting
{
    internal static class Program
    {
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            ModSetupTesting();
            //Application.Run(new Main());
        }

        private static void ModSetupTesting()
        {
            Project proj = new Project();
            proj.Features.Add(new ModFeatureMaps());
            proj.Features.Add(new ModFeatureDialog());
            ChildMultiWindow[] forms = FormFabric.GetFeatureSettingForms(proj);
            Application.Run(new MultiWindow(forms));
        }
    }
}