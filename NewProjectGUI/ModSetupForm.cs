using NewProjectGUI;
using NewProjectGUI.Forms;
using ModStudioLogic;
using ModStudioLogic.BigClasses;

namespace CelesteModStudioGUI.NewProjectForms
{
    public partial class ModSetupForm : Form
    {
        private sbyte index;
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
            index = -1;
        }

        private void ShowNextForm()
        {
            index++;
            ModFeature actualFeature = lastAdded.Features[index];
            BaseForm actualControl = FormFabric.GetUserControlFrom(actualFeature);
            this.Controls.Add(actualControl);
            actualControl.Show();
        }

        private void UserControlClosed(object sender, EventArgs e)
        {
        }
    }
}