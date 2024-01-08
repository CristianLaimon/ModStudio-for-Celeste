using NewProjectGUI;
using NewProjectGUI.Forms;
using ModStudioLogic.ProjectInside;
using ModStudioLogic.BigClasses;

namespace CelesteModStudioGUI.NewProjectForms
{
    public partial class MultiWindow : Form
    {
        private ChildMultiWindow[] _childForms;
        private sbyte _actualIndex;

        /// <summary>
        /// A multi purpose window with multiple screens
        /// </summary>
        /// <param name="windows">Needs the windows to display</param>
        public MultiWindow(params ChildMultiWindow[] windows)
        {
            _childForms = windows;
            Check();
            InitializeComponent();
            SetupThisForm();
            SetupChildForms();
            ShowActualForm();
        }

        private void SetupThisForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _actualIndex = 0;
            this.CenterToScreen();
        }

        private void Check()
        {
            if (_childForms == null || !_childForms.Any()) throw new Exception("Can't open multiwindow" +
            "with no childwindows");
        }

        private void SetupChildForms()
        {
            for (int i = 0; i < _childForms.Length; i++)
            {
                SetupChildForm(_childForms[i]);
                panelForm.Controls.Add(_childForms[i]);
            }
        }

        private void SetupChildForm(ChildMultiWindow f)
        {
            f.AboutToCloseNext = ChildClosenext;
            f.AboutToCloseBack = ChildCloseBack;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
        }

        #region FormHandling

        private void ShowActualForm()
        {
            if (HasFinishedSetup(out DialogResult result))
            {
                this.DialogResult = result;
                this.Dispose();
                this.DisposeAllChilds();
                return;
            }

            ChildMultiWindow actualForm = _childForms[_actualIndex];
            actualForm.BringToFront();
            actualForm.Show();
        }

        private bool HasFinishedSetup(out DialogResult result)
        {
            if (_actualIndex == _childForms.Length)
            {
                result = DialogResult.OK;
                return true;
            }
            else if (_actualIndex == -1)
            {
                result = DialogResult.Cancel;
                return true;
            }

            result = DialogResult.None;
            return false;
        }

        private void DisposeAllChilds()
        {
            for (int i = 0; i < _childForms.Length; i++)
            {
                _childForms[i].Hide();
                _childForms[i].Dispose();
            }
        }

        #endregion FormHandling

        private void ChildClosenext(object? sender, EventArgs e)
        {
            _actualIndex++;
            ShowActualForm();
        }

        private void ChildCloseBack(object? sender, EventArgs e)
        {
            _actualIndex--;
            ShowActualForm();
        }
    }
}