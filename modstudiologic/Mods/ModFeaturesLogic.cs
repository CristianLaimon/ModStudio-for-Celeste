namespace ModStudioLogic.Mods
{
    public abstract class ModFeature
    {
        public abstract string FolderName { get; }
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

    //public class FeatureAudio : ModFeature
    //{
    //    public override string FolderName { get { return "Notimplemented"; } }
    //}

    public class FeatureAhorn : ModFeature
    {
        public override string FolderName { get { return "Ahorn"; } }
    }

    public class FeatureLoenn : ModFeature
    {
        public override string FolderName { get { return "Loenn"; } }
    }

    //public class FeatureDLL : ModFeature
    //{
    //    public override string FolderName { get { return "NotImplemented"; } }
    //}

}