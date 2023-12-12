using ModStudioLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProjectGUI.Forms
{
    internal partial class MapsForm : BaseForm
    {
        internal MapsForm()
        {
            InitializeComponent();
            base.InitializeComponent();
        }

        protected override void CloseFormNext(object sender, EventArgs e)
        {
            Project actualProject = ProjectManager.GetLastProjectAdded();
            actualProject.CampaignName = textBox1.Text;

            base.CloseFormNext(sender, e);
        }
    }
}