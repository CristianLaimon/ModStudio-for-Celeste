using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModStudio_Logic.ModProject
{
    public class ModProject
    {
        public string ParentDirPath = string.Empty;
        public string Path = string.Empty;
        public string Version = "0.0.1";
        public string Name = string.Empty;
        public string Author = string.Empty;
        public string CampaignName = string.Empty;
        public List<ModFeatures> ProjectFeatures = new List<ModFeatures>();
    }
}
