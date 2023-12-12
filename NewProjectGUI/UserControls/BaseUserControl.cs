using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProjectGUI.UserControls
{
    internal abstract class BaseUserControl : UserControl
    {
        internal delegate void ClosedUserControl(object obj, EventArgs e);

        internal event ClosedUserControl Closed;

        protected virtual void OnUserControlClosed(EventArgs e)
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}