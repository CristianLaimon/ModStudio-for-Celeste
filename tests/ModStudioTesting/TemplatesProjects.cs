using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
using Version = ModStudioLogic.ProyectInside.Version;

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

            //Setup Features
            simpleProject.Features.Add(new ModFeatureMaps());
            simpleProject.Features.Add(new ModFeatureDialog());

            return simpleProject;
        }
    }
}