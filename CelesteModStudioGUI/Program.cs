namespace CelesteModStudioGUI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoadForm());
            Application.Run(new Main());
        }
    }
}