using Microsoft.VisualBasic;

namespace ModStudioLogic
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

    public interface IModStudioState
    {
        string GetMessage();
    }

    public class FormStateDefault : IModStudioState
    {
        public string GetMessage()
        {
            return "Running";
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
        private string _customMessage;

        public FormStateError(string message)
        {
            _customMessage = message;
        }

        public string GetMessage()
        {
            return _customMessage;
        }
    }

    public class FormStateCreatingProject : IModStudioState
    {
        public string GetMessage()
        {
            return "Creating Project";
        }
    }

    public class FormStateCustomMessage : IModStudioState
    {
        private string _message;

        public FormStateCustomMessage(string message)
        {
            _message = message;
        }

        public string GetMessage()
        {
            return _message;
        }
    }
}