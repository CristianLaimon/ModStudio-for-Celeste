using ModStudio_for_Celeste.NewProjectForms;

namespace ModStudio_for_Celeste
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}