using ModStudioLogic.BigClasses;
using ModStudioLogic.Exceptions;
using NewProjectGUI.View.Forms;

namespace NewProjectGUI
{
    internal class UserControlFabric
    {
        internal static UserControl GetUserControlFrom(ModFeature feature)
        {
            switch (feature)
            {
                case ModFeatureMaps:
                    return new MapsControl();

                //case ModFeatureLoenn:
                //    break;

                //case ModFeatureDLL:
                //    break;

                //case ModFeatureDialog:
                //    break;

                //case ModFeatureAudio:
                //    break;

                //case ModFeatureAhorn:
                //    break;

                default:
                    throw new ModException("Fail to instancer a user control" +
                        "from ModFeature object", feature);
            }
        }
    }
}