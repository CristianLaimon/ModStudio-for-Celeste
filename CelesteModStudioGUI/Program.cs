namespace CelesteModStudioGUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoadForm());
            Application.Run(new Main());
        }
    }
}