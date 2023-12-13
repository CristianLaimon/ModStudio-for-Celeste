namespace NewProjectGUI.Forms
{
    internal delegate void MyDel(object obj, EventArgs e);

    internal partial class BaseForm : Form
    {
        internal MyDel AboutToCloseNext;
        internal MyDel AboutToCloseBack;

        internal BaseForm()
        {
            InitializeComponent();
        }

        protected virtual void CloseFormNext(object sender, EventArgs e)
        {
            AboutToCloseNext?.Invoke(sender, e);
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void CloseFormBack(object sender, EventArgs e)
        {
            AboutToCloseBack?.Invoke(sender, e);
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}