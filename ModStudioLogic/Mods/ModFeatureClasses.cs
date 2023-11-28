using System.Security.Cryptography.X509Certificates;

namespace ModStudioLogic.Mods
{
    public class ModFeature
    {
        public virtual string FolderName { get { return "NAN"; } }
    }

    public class FeatureMaps : ModFeature
    {
        public override string FolderName { get { return "Maps"; } }
    }

    public class FeatureDialog : ModFeature
    {
        public override string FolderName { get { return "Dialog"; } }
    }

    public class FeatureGraphics : ModFeature
    {
        public override string FolderName { get { return "Graphics"; } }
    }

    public class FeatureAhorn : ModFeature
    {
        public override string FolderName { get { return "Ahorn"; } }
    }

    public class FeatureLoenn : ModFeature
    {
        public override string FolderName { get { return "Loenn"; } }
    }

    public class FeatureDLL : ModFeature
    {
        public override string FolderName { get { return "bin"; } }
    }

    public class FeatureAudio : ModFeature
    {
        public override string FolderName { get { return "Audio"; } }
    }

    public static class ModFeatureFactory
    {
        public static ModFeature GetFeatureByName(string featureName)
        {
            switch (featureName.ToLower())
            {
                case "maps":
                    return new FeatureMaps();
                case "dialog":
                    return new FeatureDialog();
                case "graphics":
                    return new FeatureGraphics();
                case "ahorn":
                    return new FeatureAhorn();
                case "loenn":
                    return new FeatureLoenn();
                case "dll":
                    return new FeatureDLL();
                case "audio":
                    return new FeatureAudio();
                default:
                    return new ModFeature();
            }
        }
    }
}