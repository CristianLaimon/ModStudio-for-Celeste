using ModStudioLogic.BigClasses;
using ModStudioLogic.Exceptions;
using ModStudioLogic.ProjectInside;
using NewProjectGUI.Forms;

namespace NewProjectGUI
{
    public class FormFabric
    {
        public static ChildMultiWindow[] GetFeatureSettingForms(Project fromProject)
        {
            var output = new List<ChildMultiWindow>();
            foreach (var feature in fromProject.Features)
            {
                switch (feature)
                {
                    case ModFeatureMaps:
                        output.Add(new MapsForm(fromProject));
                        break;

                    case ModFeatureDialog:
                        output.Add(new Dialogform(fromProject));
                        break;
                        //case ModFeatureLoenn:
                        //    break;

                        //case ModFeatureDLL:
                        //    break;

                        //case ModFeatureAudio:
                        //    break;

                        //case ModFeatureAhorn:
                        //    break;
                }
            }
            return output.ToArray(); ;
        }
    }
}