using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProjectGUI.UserControls
{
    internal delegate void OnClosedUserControl();

    internal partial class BaseControl : UserControl
    {
        internal OnClosedUserControl OnClosedDelegate;

        internal BaseControl()
        {
            InitializeComponent();
        }

        protected void OnClosedUserControl()
        {
            OnClosedDelegate?.Invoke();
        }
    }
}