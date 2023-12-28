using ModStudioLogic.ProjectInside;
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
        public virtual DirectoryInfo CreateDirsAndFiles(Project project)
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
        public override string FolderName => "Maps";

        public override string Extension => ".bin";

        public override DirectoryInfo CreateDirsAndFiles(Project project)
        {
            string path = Path.Combine(
                project.FullPath,
                FolderName,
                project.AuthorName,
                project.CampaignName);

            DirectoryInfo returnInfo = Directory.CreateDirectory(path);

            foreach (string mapName in project.Maps)
            {
                Loenn.CreateNewMap(path, mapName);
            }

            return returnInfo;
        }
    }

    public class ModFeatureDialog : ModFeature
    {
        public List<string> Languages = new();
        public override string Extension => ".txt";
        public override string FolderName => "Dialog";

        public override DirectoryInfo CreateDirsAndFiles(Project project)
        {
            DirectoryInfo info = base.CreateDirsAndFiles(project);

            foreach (string str in Languages)
            {
                File.Create(Path.Combine(info.FullName, str + Extension));
            }

            return info;
        }
    }

    public class ModFeatureLoenn : ModFeature
    {
        public override string FolderName => "Loenn";
        public override string Extension => ".lua";

        public readonly string LanguageExtension = ".language";
    }

    public class ModNullFeature : ModFeature
    {
        public override string FolderName => throw new NotImplementedException();

        public override string Extension => throw new NotImplementedException();

        public override DirectoryInfo CreateDirsAndFiles(Project project)
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

                case "loenn":
                    return new ModFeatureLoenn();

                default:
                    return new ModNullFeature();
            }
        }
    }
}

//case "graphics":
//    return new FeatureGraphics();

//case "ahorn":
//    return new ModFeatureAhorn();

//case "dll":
//    return new ModFeatureDLL();

//case "audio":
//    return new ModFeatureAudio();

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

//public class ModFeatureYAML : ModFeature
//{
//    public new static string FolderName
//    { get { return "None"; } }

//    public override string Extension
//    { get { return ".yaml"; } }
//}