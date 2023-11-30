namespace CelesteModStudioGUI.NewProjectForms
{
    partial class ModSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelAllForms = new Panel();
            SuspendLayout();
            // 
            // panelAllForms
            // 
            panelAllForms.Dock = DockStyle.Fill;
            panelAllForms.Location = new Point(0, 0);
            panelAllForms.Name = "panelAllForms";
            panelAllForms.Size = new Size(676, 370);
            panelAllForms.TabIndex = 0;
            // 
            // ModSetupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 370);
            Controls.Add(panelAllForms);
            Name = "ModSetupForm";
            Text = "Maps - Setup";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAllForms;
    }
}