using System.Windows.Forms;

namespace ModStudioLogic.BigClasses
{
    public abstract class ModFeature
    {
        public abstract string FolderName { get; }

        //This is bad!
        public virtual DirectoryInfo CreateFolders(Project project)
        {
            string path = Path.Combine(
                project.FullPath,
                FolderName
                );

            return Directory.CreateDirectory(path);
        }
    }

    public class ModFeatureMaps : ModFeature
    {
        public override string FolderName
        { get { return "Maps"; } }

        public override DirectoryInfo CreateFolders(Project project)
        {
            string path = Path.Combine(
                project.FullPath,
                FolderName,
                project.AuthorName,
                project.CampaignName);

            return Directory.CreateDirectory(path);
        }
    }

    public class ModFeatureDialog : ModFeature
    {
        public override string FolderName
        { get { return "Dialog"; } }
    }

    public class FeatureGraphics : ModFeature
    {
        public override string FolderName
        { get { return "Graphics"; } }
    }

    public class ModFeatureAhorn : ModFeature
    {
        public override string FolderName
        { get { return "Ahorn"; } }
    }

    public class ModFeatureLoenn : ModFeature
    {
        public override string FolderName
        { get { return "Loenn"; } }
    }

    public class ModFeatureDLL : ModFeature
    {
        public override string FolderName
        { get { return "bin"; } }
    }

    public class ModFeatureAudio : ModFeature
    {
        public override string FolderName
        { get { return "Audio"; } }
    }

    public class ModNullFeature : ModFeature
    {
        public override string FolderName => throw new NotImplementedException();

        public override DirectoryInfo CreateFolders(Project project)
        {
            throw new NotImplementedException();
        }
    }

    public static class ModFeatureFactory
    {
        public static ModFeature GetFeatureByName(string featureName)
        {
            switch (featureName.ToLower())
            {
                case "maps":
                    return new ModFeatureMaps();

                case "dialog":
                    return new ModFeatureDialog();

                case "graphics":
                    return new FeatureGraphics();

                case "ahorn":
                    return new ModFeatureAhorn();

                case "loenn":
                    return new ModFeatureLoenn();

                case "dll":
                    return new ModFeatureDLL();

                case "audio":
                    return new ModFeatureAudio();

                default:
                    return new ModNullFeature();
            }
        }
    }
}