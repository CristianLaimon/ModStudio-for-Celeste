using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ModStudioLogic
{
    public class FormValidation
    {
        public static bool TextBoxesAreValid(params TextBox[] textBoxes)
        {
            string pattern = @"^[a-zA-Z0-9\-_]+$";

            foreach (var txtBox in textBoxes)
            {
                if (!Regex.IsMatch(txtBox.Text, pattern))
                    return false;
            }

            return true;
        }
    }
}