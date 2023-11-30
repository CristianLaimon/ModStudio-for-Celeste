namespace ModStudioLogic
{
    public class Project
    {
        /// <summary>
        /// This includes the full path including "...ParentFolder/ModName/..."
        /// </summary>
        public string FullPath = string.Empty;
        public string ModVersion = "0.0.1";
        public string ModName = string.Empty;
        public string AuthorName = string.Empty;
        public string CampaignName = string.Empty;
        public List<ModFeature> Features = new List<ModFeature>();
    }
}