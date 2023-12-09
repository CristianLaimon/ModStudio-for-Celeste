using CelesteModStudioGUI.NewProjectForms.FeaturesForms;
using CelesteModStudioGUI.View.Forms;

namespace CelesteModStudioGUI.Model
{
    public abstract class ModFeature
    {
        public virtual UserControl SettingWindow { get; }
        public abstract string FolderName { get; }
        public virtual DirectoryInfo CreateFolders(Project project)
        {
            string path = Path.Combine(
                project.FullPath,
                FolderName
                );


            return Directory.CreateDirectory(path);
        }
    }

    public class FeatureMaps : ModFeature
    {
        public override UserControl SettingWindow => new UserControl1();
        public override string FolderName { get { return "Maps"; } }
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

    public class NullFeature : ModFeature
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
                    return new NullFeature();
            }
        }
    }
}