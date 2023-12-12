namespace NewProjectGUI.Forms
{
    internal delegate void MyDel(object obj, EventArgs e);

    internal partial class BaseForm : Form
    {
        internal MyDel AboutToClose;

        internal BaseForm()
        {
            InitializeComponent();
        }

        protected virtual void CloseForm(object sender, EventArgs e)
        {
            AboutToClose?.Invoke(sender, e);
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}