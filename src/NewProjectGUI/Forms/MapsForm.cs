using ModStudioLogic;
using ModStudioLogic.ProjectInside;
using Timer = System.Windows.Forms.Timer;

namespace NewProjectGUI.Forms
{
    internal partial class MapsForm : BaseForm
    {
        private Timer timer;

        internal MapsForm()
        {
            InitializeComponent();
            Setup();
            base.InitializeComponent();
        }

        private void Setup()
        {
            labelError.Text = String.Empty;
            timer = new Timer();
            timer.Interval = 2500;
            timer.Tick += TimerElapsed;
        }

        protected override void CloseFormNext(object sender, EventArgs e)
        {
            if (FormValidation.TextBoxesAreValid(this.Controls.OfType<TextBox>().ToArray()))
            {
                Project actualProject = Projects.GetLastProjectAdded();
                actualProject.CampaignName = textBoxCampaignName.Text;

                actualProject.Maps.Add(textBoxFirstMapName.Text);
                base.CloseFormNext(sender, e);
            }
            else
            {
                labelError.Text = "Not valid input. Try Again";
                timer.Start();
            }
        }

        private void TimerElapsed(object sender, EventArgs e)
        {
            Timer senderTimer = sender as Timer;

            if (senderTimer != null)
                senderTimer.Stop();

            labelError.Text = string.Empty;
        }
    }
}