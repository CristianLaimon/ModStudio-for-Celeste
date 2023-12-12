using NewProjectGUI;
using NewProjectGUI.Forms;
using ModStudioLogic;
using ModStudioLogic.BigClasses;

namespace CelesteModStudioGUI.NewProjectForms
{
    public partial class ModSetupForm : Form
    {
        private sbyte _shownFormIndex;
        private Project lastAdded;

        public ModSetupForm()
        {
            InitializeComponent();
            Setup();
            ShowNextForm();
        }

        private void Setup()
        {
            lastAdded = ProjectManager.GetLastProjectAdded();
            _shownFormIndex = -1;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ShowNextForm()
        {
            _shownFormIndex++;

            //If all settings forms have been shown, close this form
            if (_shownFormIndex == lastAdded.Features.Count)
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                return;
            }

            //Get the form
            ModFeature actualFeature = lastAdded.Features[_shownFormIndex];
            BaseForm child = FormFabric.GetSettingFormFrom(actualFeature);

            //Setup Form
            child.AboutToClose = ChildCloseEvent;
            child.FormBorderStyle = FormBorderStyle.None;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;

            panelForm.Controls.Add(child);

            //Show it
            child.BringToFront();
            child.Show();
        }

        //im disposing a form and THEN removing this event (in that order). is it right?
        private void ChildCloseEvent(object? sender, EventArgs e)
        {
            ShowNextForm();
        }
    }
}