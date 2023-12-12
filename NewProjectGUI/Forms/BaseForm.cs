namespace NewProjectGUI.Forms
{
    internal partial class BaseForm : Form
    {
        internal BaseForm()
        {
            InitializeComponent();
        }

        protected virtual void CloseForm(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}