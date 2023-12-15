using Timer = System.Windows.Forms.Timer;

namespace CelesteModStudioGUI
{
    public partial class LoadForm : Form
    {
        private Timer timer;

        public LoadForm()
        {
            InitializeComponent();
            SetFormConfig();
            SetTimerLogic();
        }

        private void SetFormConfig()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.CenterToScreen();
        }

        private void SetTimerLogic()
        {
            timer = new Timer();
            timer.Tick += ElapsedTime;
            timer.Interval = 2000;
            timer.Start();
        }

        private void ElapsedTime(object? sender, EventArgs e)
        {
            timer.Stop();
            timer = null;
            this.Dispose();
        }
    }
}