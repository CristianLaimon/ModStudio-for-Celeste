using NewProjectGUI;
using NewProjectGUI.Forms;
using ModStudioLogic;
using ModStudioLogic.BigClasses;

namespace CelesteModStudioGUI.NewProjectForms
{
    public partial class ModSetupForm : Form
    {
        private sbyte _actualIndex;
        private Project _actualProject;
        private BaseForm[] _loadedForms;

        public ModSetupForm()
        {
            InitializeComponent();
            SetupThisForm();
            LoadForms();
            ShowActualForm();
        }

        #region Setup

        private void SetupThisForm()
        {
            _actualProject = Projects.GetLastProjectAdded();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _actualIndex = 0;
            this.CenterToScreen();
        }

        private void LoadForms()
        {
            _loadedForms = new BaseForm[_actualProject.Features.Count];

            for (int i = 0; i < _actualProject.Features.Count; i++)
            {
                BaseForm newForm = FormFabric.GetSettingFormFrom(_actualProject.Features[i]);
                SetupBaseForm(newForm);
                _loadedForms[i] = newForm;
                panelForm.Controls.Add(newForm);
            }
        }

        #endregion Setup

        private void ShowActualForm()
        {
            if (HasFinishedSetup(out DialogResult result))
            {
                this.DialogResult = result;
                this.Dispose();
                this.DisposeAllChilds();
                return;
            }

            BaseForm actualForm = _loadedForms[_actualIndex];
            actualForm.BringToFront();
            actualForm.Show();
        }

        #region Utilities

        private bool HasFinishedSetup(out DialogResult result)
        {
            if (_actualIndex == _actualProject.Features.Count)
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
            for (int i = 0; i < _loadedForms.Length; i++)
                _loadedForms[i].Dispose();
        }

        private void SetupBaseForm(BaseForm f)
        {
            f.AboutToCloseNext = ChildClosenext;
            f.AboutToCloseBack = ChildCloseBack;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
        }

        #endregion Utilities

        #region ChildEvents

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

        #endregion ChildEvents
    }
}