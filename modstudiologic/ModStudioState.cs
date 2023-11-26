using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModStudio_Logic
{
    public enum State
    {
        Default,
        Startup,
        ChoosingFile, 
        Choosing,
        ChoosingDirectory
    }

    public class ModStudioState
    {
        public static string GetMessageByState(State actualState)
        {
            string format = " --- ";
            string message;

            switch (actualState)
            {
                case State.Default:
                    message = "";
                    break;

                case State.Startup:
                    message = format + "Startup Completed" + format;
                    break;

                case State.ChoosingFile:
                    message = format + "Choosing File..." + format;
                    break;

                case State.Choosing:
                    message = format + "Choosing..." + format;
                    break;

                case State.ChoosingDirectory:
                    message = format + "Choosing Directory..." + format;
                    break;

                default:
                    message = "There's no state";
                    break;
            }

            return message;
        }
    }
}
