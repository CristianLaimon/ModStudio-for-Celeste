using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewProjectGUI.UserControls;

namespace NewProjectGUI.View.Forms
{
    public partial class MapsControl : UserControl
    {
        public MapsControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Closed?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }
    }
}