using ModStudioLogic.ProjectInside;

namespace NewProjectGUI.Forms
{
    internal partial class MapsForm : BaseForm
    {
        internal MapsForm()
        {
            InitializeComponent();
            base.InitializeComponent();
        }

        protected override void CloseFormNext(object sender, EventArgs e)
        {
            Project actualProject = Projects.GetLastProjectAdded();
            actualProject.CampaignName = textBox1.Text;

            base.CloseFormNext(sender, e);
        }
    }
}