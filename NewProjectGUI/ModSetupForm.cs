using CelesteModStudioGUI.View.Forms;

namespace CelesteModStudioGUI.NewProjectForms
{
    public partial class ModSetupForm : Form
    {
        public ModSetupForm()
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