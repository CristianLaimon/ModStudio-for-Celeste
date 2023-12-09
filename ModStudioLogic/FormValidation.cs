using System.Windows.Forms;

namespace ModStudioLogic
{
    public class FormValidation
    {
        public static bool TextBoxesAreValid(params TextBox[] textBoxes)
        {
            bool theyreValid = true;

            foreach (var txtBox in textBoxes)
            {
                if (txtBox == null || txtBox.Text == "")
                {
                    theyreValid = false;
                }
            }

            return theyreValid;
        }
    }
}