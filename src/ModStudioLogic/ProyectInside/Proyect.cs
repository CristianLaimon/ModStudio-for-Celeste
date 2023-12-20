using ModStudioLogic.BigClasses;
using ModStudioLogic.ProyectInside;
using Version = ModStudioLogic.ProyectInside.Version;

namespace ModStudioLogic.ProjectInside
{
    public class Proyect
    {
        /// <summary>
        /// This includes the full path including "...ParentFolder/ModName/..."
        /// </summary>
        public string FullPath = string.Empty;

        public string ModName = string.Empty;
        public string AuthorName = string.Empty;
        public string CampaignName = string.Empty;
        public Version ModVersion = new Version(0, 1, 0);
        public List<ModFeature> Features = new List<ModFeature>();
        public EverestYaml Yaml;
    }
}