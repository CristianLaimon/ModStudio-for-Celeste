using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelesteModStudioGUI
{
    public partial class BaseTabControl : UserControl
    {
        public BaseTabControl()
        {
            InitializeComponent();
        }

        protected virtual void CloseLogic(object? sender, EventArgs e)
        {
            TabPage parentTab = (TabPage)this.Parent;
            TabControl grandFather = (TabControl)parentTab.Parent;
            grandFather.TabPages.Remove(parentTab);
        }
    }
}