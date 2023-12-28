namespace CelesteModStudioGUI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
#if !DEBUG
            Application.Run(new LoadForm());
#endif
            Application.Run(new Main());
        }
    }
}