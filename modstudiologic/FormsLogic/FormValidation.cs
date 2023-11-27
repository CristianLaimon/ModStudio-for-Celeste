using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModStudio_Logic.FormsLogic
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
