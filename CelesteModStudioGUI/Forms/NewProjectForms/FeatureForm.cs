using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelesteModStudioGUI.NewProjectForms.FeaturesForms
{
    public partial class FeatureForm : Form
    {
        public FeatureForm()
        {
            InitializeComponent();
            this.Size = new Size(676, 370);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
