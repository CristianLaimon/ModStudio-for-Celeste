using ModStudioLogic.BigClasses;
using ModStudioLogic.ProyectInside;
using Version = ModStudioLogic.Version;

namespace ModStudioLogic.ProjectInside
{
    public class Project
    {
        /// <summary>
        /// This includes the full path including "...ParentFolder/ModName/..."
        /// </summary>
        public string FullPath = string.Empty;

        public EverestYaml Yaml;
        public string ModName = string.Empty;
        public string AuthorName = string.Empty; //I think this should be, more than one
        public string CampaignName = string.Empty;
        public Version ModVersion = new Version(0, 1, 0);
        public List<ModFeature> Features = new List<ModFeature>();
        public List<string> Maps = new List<string>();

        #region Essential

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Project other = obj as Project;

            if (other == null)
                return false;

            return this.FullPath == other.FullPath;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion Essential
    }
}