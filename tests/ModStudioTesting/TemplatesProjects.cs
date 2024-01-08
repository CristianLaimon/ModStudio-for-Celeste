using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
using Version = ModStudioLogic.Version;

namespace ModStudioTesting
{
    public class TemplatesProjects
    {
        public static Project GetSimpleProject()
        {
            Project simpleProject = new Project();

            simpleProject.FullPath = "C:\\Users\\itan_\\Desktop\\SimpleProject";
            simpleProject.AuthorName = "Christian Laimon";
            simpleProject.CampaignName = "PortalineCampaign";
            simpleProject.ModName = "PortaLineMod";
            simpleProject.ModVersion = new Version(0, 1, 0);
            simpleProject.Maps = new List<string>() { "MyFirstMap" };

            //Setup maps
            simpleProject.Features.Add(new ModFeatureMaps());

            //Setup dialog
            var dialog = new ModFeatureDialog();
            dialog.Languages = new List<string>() { "Spanish", "English" };
            simpleProject.Features.Add(dialog);

            return simpleProject;
        }
    }
}