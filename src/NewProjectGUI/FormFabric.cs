using ModStudioLogic.BigClasses;
using ModStudioLogic.Exceptions;
using NewProjectGUI.Forms;

namespace NewProjectGUI
{
    internal class FormFabric
    {
        internal static BaseForm GetSettingFormFrom(ModFeature feature)
        {
            switch (feature)
            {
                case ModFeatureMaps:
                    return new MapsForm();

                //case ModFeatureLoenn:
                //    break;

                //case ModFeatureDLL:
                //    break;

                case ModFeatureDialog:
                    return new Dialogform();

                //case ModFeatureAudio:
                //    break;

                //case ModFeatureAhorn:
                //    break;

                default:
                    throw new ModException("Fail to instance a user control" +
                        "from ModFeature object", feature);
            }
        }
    }
}