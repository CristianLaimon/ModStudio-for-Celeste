using CelesteModStudioGUI.Controller.ModStudioLogic;
using CelesteModStudioGUI.Model;
using CelesteModStudioGUI.NewProjectForms.FeaturesForms;
using CelesteModStudioGUI.View.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelesteModStudioGUI.NewProjectForms
{
    public partial class FeaturesMultiSelectForm : Form
    {
        public FeaturesMultiSelectForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            UserControl ch = new UserControl1();
            ch.Dock = DockStyle.Fill;
            this.Controls.Add(ch);
            ch.Show();
        }
    }
}
