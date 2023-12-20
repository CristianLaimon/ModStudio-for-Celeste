using ModStudioLogic.BigClasses;
using ModStudioLogic.ProjectInside;
using System.Collections.Generic;

namespace NewProjectGUI.Forms
{
    internal partial class Dialogform : BaseForm
    {
        internal Dialogform()
        {
            InitializeComponent();
            base.InitializeComponent();
        }

        protected override void CloseFormNext(object sender, EventArgs e)
        {
            List<string> langs = GetLanguagesFromForm();
            ModFeatureDialog diag = GetThisProjectDialog();
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
            Project last = Projects.LastProject;
            ModFeatureDialog dialog;
            foreach (ModFeature feat in last.Features)
            {
                if (feat is ModFeatureDialog)
                {
                    dialog = (ModFeatureDialog)feat;
                    return dialog;
                }
            }

            throw new InvalidOperationException("There aren't ModFeatureDialog object inside this project features...");
        }
    }
}