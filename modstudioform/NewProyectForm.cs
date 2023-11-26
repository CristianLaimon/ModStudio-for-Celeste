using ModStudio_Logic;
using ModStudioLogic;
using System.Reflection.Metadata;

namespace ModStudio_for_Celeste
{
    public partial class NewProyectForm : Form
    {
        State _formState;

        private State FormState
        {
            get { return _formState; }
            set
            {
                _formState = value;
                UpdateStatusStringForm(_formState);
            }
        }

        public NewProyectForm()
        {
            InitializeComponent();
            InitialConfig();
        }

        private void InitialConfig()
        {
            this.CenterToScreen();
            FormState = State.Default;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonSelectNewDirectory_Click(object sender, EventArgs e)
        {
            FormState = State.ChoosingDirectory;

            if (FileManager.TryOpenNewDirectory(out string dir))
            {
                ProjectData.ProyectPath = dir;
                textBoxDirectorySelected.Text = dir;
            }

            FormState = State.Default;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(FormValidation.TextBoxesAreValid(this.Controls.OfType<TextBox>().ToArray()))
            {





                DialogResult = DialogResult.OK;
            }
            else
            {
                stripLabelActualStatus.Text = "No valid input. Please try again";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void UpdateStatusStringForm(State newState)
        {
            stripLabelActualStatus.Text = ModStudioState.GetMessageByState(newState);
        }
    }
}
