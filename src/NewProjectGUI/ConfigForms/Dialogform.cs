using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
using System.Collections.Generic;

namespace NewProjectGUI.Forms
{
    public partial class Dialogform : ChildMultiWindow
    {
        private Project _tempProj;

        internal Dialogform(Project tempProj)
        {
            _tempProj = tempProj;

            InitializeComponent();
            base.InitializeComponent();
        }

        protected override void CloseFormNext(object sender, EventArgs e)
        {
            ModFeatureDialog diag = GetThisProjectDialog();
            List<string> langs = GetLanguagesFromForm();
            diag.Languages = langs;

            base.CloseFormNext(sender, e);
        }

        private List<string> GetLanguagesFromForm()
        {
            List<string> list = new List<string>();
            foreach (var checkBox in groupBoxSelectDialog.Controls.OfType<CheckBox>())
            {
                string language = checkBox.Text.Substring(0, checkBox.Text.Length - 4); //removing ".txt"
                list.Add(language);
            }
            return list;
        }

        private ModFeatureDialog GetThisProjectDialog()
        {
            ModFeatureDialog dialog = null;
            foreach (ModFeature feat in _tempProj.Features)
            {
                if (feat is ModFeatureDialog)
                {
                    dialog = (ModFeatureDialog)feat;
                    return dialog;
                }
            }

            return dialog ?? new ModFeatureDialog();
        }
    }
}