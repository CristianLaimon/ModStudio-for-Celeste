namespace NewProjectGUI.Forms
{
    internal delegate void MyDel(object obj, EventArgs e);

    public partial class ChildMultiWindow : Form
    {
        internal MyDel AboutToCloseNext;
        internal MyDel AboutToCloseBack;

        internal ChildMultiWindow()
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