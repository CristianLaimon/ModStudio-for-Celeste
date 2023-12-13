using System.Windows.Forms;

namespace ModStudioLogic.BigClasses
{
    //ModFeatures are independent from project class!? (are they generic? for every project)
    //TODO: Possible rethinking about how this classes are gonna work in future

    public abstract class ModFeature
    {
        public abstract string FolderName { get; }
        public abstract string Extension { get; }

        /// <summary>
        /// Create all necessary subfolders to implement this modfeature.
        /// </summary>
        /// <returns>All info related to the new folder created (and it's subfolders)</returns>
        public virtual DirectoryInfo CreateFoldersBasedOn(Project project)
        {
            string path = Path.Combine(
                project.FullPath,
                FolderName
                );

            return Directory.CreateDirectory(path);
        }
    }

    public class ModFeatureYAML : ModFeature
    {
        public override string FolderName
        { get { return "None"; } }

        public override string Extension
        { get { return ".yaml"; } }
    }

    public class ModFeatureMaps : ModFeature
    {
        public override string FolderName
        { get { return "Maps"; } }

        public override string Extension
        { get { return ".dat"; } }

        public override DirectoryInfo CreateFoldersBasedOn(Project project)
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
        public List<string> Languages = new();
        public override string Extension => ".txt";

        public override string FolderName
        { get { return "Dialog"; } }
    }

    //public class FeatureGraphics : ModFeature
    //{
    //    public override string FolderName
    //    { get { return "Graphics"; } }
    //}

    //public class ModFeatureAhorn : ModFeature
    //{
    //    public override string FolderName
    //    { get { return "Ahorn"; } }
    //}

    public class ModFeatureLoenn : ModFeature
    {
        public override string Extension
        { get { return ".lua"; } }

        public readonly string LanguageExtension = ".language";

        public override string FolderName
        { get { return "Loenn"; } }
    }

    //public class ModFeatureDLL : ModFeature
    //{
    //    public override string Extension
    //    { get { return ".dll"; } }

    //    public override string FolderName
    //    { get { return "bin"; } }
    //}

    //public class ModFeatureAudio : ModFeature
    //{
    //    public override string FolderName
    //    { get { return "Audio"; } }
    //}

    public class ModNullFeature : ModFeature
    {
        public override string FolderName => throw new NotImplementedException();

        public override string Extension
        { get { return "ModNullFeatureNoExtension"; } }

        public override DirectoryInfo CreateFoldersBasedOn(Project project)
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

                //case "graphics":
                //    return new FeatureGraphics();

                //case "ahorn":
                //    return new ModFeatureAhorn();

                case "loenn":
                    return new ModFeatureLoenn();

                //case "dll":
                //    return new ModFeatureDLL();

                //case "audio":
                //    return new ModFeatureAudio();

                default:
                    return new ModNullFeature();
            }
        }
    }
}