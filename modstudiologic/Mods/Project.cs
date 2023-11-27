namespace ModStudioLogic.Mods
{
    public class Project
    {
        public string ParentDirPath = string.Empty;
        public string Path = string.Empty;
        public string Version = "0.0.1";
        public string Name = string.Empty;
        public string Author = string.Empty;
        public string CampaignName = string.Empty;
        public List<ModFeature> Features = new List<ModFeature>();
    }
}