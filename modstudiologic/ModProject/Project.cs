using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModStudioLogic.Enums;

namespace ModStudioLogic.ModProject
{
    public class Project
    {
        public string ParentDirPath = string.Empty;
        public string ProjectPath = string.Empty;
        public string ModVersion = "0.0.1";
        public string ModName = string.Empty;
        public string ModAuthor = string.Empty;
        public string CampaignName = string.Empty;
        public List<ModFeatures> ProjectFeatures = new List<ModFeatures>();
    }
}
