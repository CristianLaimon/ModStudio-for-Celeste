using ModStudioLogic;
using ModStudioLogic.FormsLogic;
using ModStudioLogic.Mods;
//https://www.reddit.com/r/celestegame/comments/e82ncn/madeline_fanart/ logo.png idea!, TODO:try to find original author...
//Probably are better ways to implement state pattern, i just wanna learn to use polymorphism. It's curious



//TODO: Make UnitTesting of all this methods
//En base a los features elegidos, poner su correspondiente form de configuraci�n
//hacer que el m�todo de a�adir features a proyecto sea "params Feature[]" y acepte cualquier cantidad. "Comodidad"
//Hacer que el visual studio pueda agrupar los #regions con el atajo para hacer fold a los m�todos. ay dios, que enfadoso
namespace CelesteModStudioGUI
{
    public partial class Main : Form
    {
        private IModStudioState _formState;
        public Main()
        {
            InitializeComponent();
            SetState(new FormStateStartup());
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void OpenProject()
        {
            SetState(new FormStateChoosingDirectory());
            if (FileManager.ShowOpenDirectoryDialog(out string dir) && FileManager.IsValidModProyect(dir))
            {
                Project opened = new Project();
                opened.FullPath = dir;
                ProjectManager.AddProject(opened);
                SetState(new FormStateDefault());
            }
            else
            {
                SetState(new FormStateError("Error: Opened Project is not a celeste mod or valid directory to work with"));
            }
        }
        private void CreateProject()
        {
            SetState(new FormStateCreatingProject());
            var newProyectForm = new NewProyectForm();
            newProyectForm.ShowDialog();
            SetState(new FormStateDefault());
        }

        #region FormEvents
        private void openExistingProyectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProject();
        }
        private void createNewModProyectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateProject();
        }
        #endregion FormEvents

        #region Utilities
        private void SetState(IModStudioState newState)
        {
            _formState = newState;
            toolStripStatusLabelStatus.Text = StateFormat.GetFormattedMessage(_formState);
        }
        #endregion Utilities
    }
}