using System.Windows.Forms;

namespace ModStudioWinForms
{
    public class NewProjectManager
    {
        private static sbyte actualForm = -1;
        private static List<Form> queueFeaturesForm = new List<Form>();

        public static void Add(Form form)
        {
            queueFeaturesForm.Add(form);
        }

        public static Form GetBeforeForm()
        {
            actualForm--;
            return queueFeaturesForm[actualForm];
        }

        public static Form GetNextForm()
        {
            actualForm++;
            return queueFeaturesForm[actualForm];
        }

        public static void ClearDisposeAll()
        {
            foreach(Form form in queueFeaturesForm)
            {
                form.Dispose();
            }

            queueFeaturesForm.Clear();
        }
    }
}
