namespace ModStudioLogic.ModManagers
{
    //public enum ModFeatures
    //{
    //    Audio,
    //    Dialog,
    //    Graphics,
    //    Maps,
    //    Ahorn,
    //    Loenn,
    //    DLLMod
    //}

    public abstract class ModFeature
    {
        private string _folderName;

        public ModFeature(string folderName)
        {
            _folderName = folderName;
        }

        public string FolderName {  get { return _folderName; } } 

    }

    public class FeatureMaps : ModFeature
    {
        public FeatureMaps() : base("Maps") { }
    }

    public class FeatureDialog : ModFeature
    {
        public FeatureDialog() : base("Dialog") { }
    }


    //TODO:WORK ON THIS
}