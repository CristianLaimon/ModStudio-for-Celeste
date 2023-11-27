namespace IStates
{
    /// <summary>
    /// Class to manage IModStudio objects to interact with GUI forms
    /// </summary>
    public class StateFormat
    {
        public static string GetFormattedMessage(IModStudioState actualState)
        {
            return " --- " + actualState.GetMessage() + " --- ";
        }
    }

    /// <summary>
    /// A new state has to implement this interface to be visible in forms of this project
    /// </summary>
    public interface IModStudioState
    {
        /// <summary>
        /// Gets the corresponding message for visual feedback
        /// </summary>
        /// <returns>A string with the state message of the form</returns>
        string GetMessage();
    }

    //All states available (~half plugins) for GUI messages! -----------------------
    public class FormStateDefault : IModStudioState
    {
        public string GetMessage()
        {
            return "";
        }
    }

    public class FormStateStartup : IModStudioState
    {
        public string GetMessage()
        {
            return "Startup Completed";
        }
    }

    public class FormStateChoosingFile : IModStudioState
    {
        public string GetMessage()
        {
            return "Choosing File";
        }
    }

    public class FormStateChoosing : IModStudioState
    {
        public string GetMessage()
        {
            return "Choosing";
        }
    }

    public class FormStateChoosingDirectory : IModStudioState
    {
        public string GetMessage()
        {
            return "Choosing Directory";
        }
    } 

    public class FormStateError : IModStudioState
    {
        string _customMessage;
        public FormStateError(string message)
        {
            _customMessage = message;
        }
        public string GetMessage()
        {
            return _customMessage;
        }
    }
}
