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
            CenterToScreen();
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

            //If all settings forms have been shown, close this form (Completed)
            if (_shownFormIndex == lastAdded.Features.Count)
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                return;
            }

            //If user go back 'til the beginning and doesnt complete this form
            if (_shownFormIndex == -1)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Dispose();
                return;
            }

            //Get the form
            ModFeature actualFeature = lastAdded.Features[_shownFormIndex];
            BaseForm child = FormFabric.GetSettingFormFrom(actualFeature);

            //Setup Form
            child.AboutToCloseNext = ChildClosenext;
            child.AboutToCloseBack = ChildCloseBack;
            child.FormBorderStyle = FormBorderStyle.None;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;

            panelForm.Controls.Add(child);

            //Show it
            child.BringToFront();
            child.Show();
        }

        //im disposing a form and THEN removing this event (in that order). is it right?
        private void ChildClosenext(object? sender, EventArgs e)
        {
            ShowNextForm();
        }

        private void ChildCloseBack(object? sender, EventArgs e)
        {
            //two steps back, one forward (thats how i think to go back one index)
            _shownFormIndex -= 2;
            ShowNextForm();
        }
    }
}