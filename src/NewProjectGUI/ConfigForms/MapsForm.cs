using ModStudioLogic;
using ModStudioLogic.ProjectInside;
using Timer = System.Windows.Forms.Timer;

namespace NewProjectGUI.Forms
{
    public partial class MapsForm : ChildMultiWindow
    {
        private Timer timer;
        private Project _tempProj;

        public MapsForm(Project tempProj)
        {
            _tempProj = tempProj;
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
            CheckIfHasCampaign();
        }

        private void CheckIfHasCampaign()
        {
            if (_tempProj.CampaignName != String.Empty)
            {
                textBoxCampaignName.Text = _tempProj.CampaignName;
                textBoxCampaignName.ReadOnly = true;
            }
        }

        protected override void CloseFormNext(object sender, EventArgs e)
        {
            if (FormValidation.TextBoxesAreValid(this.Controls.OfType<TextBox>().ToArray()))
            {
                _tempProj.CampaignName = textBoxCampaignName.Text;
                _tempProj.Maps.Add(textBoxFirstMapName.Text);
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