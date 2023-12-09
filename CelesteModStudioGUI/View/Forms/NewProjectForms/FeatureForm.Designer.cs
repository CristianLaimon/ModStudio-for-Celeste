namespace CelesteModStudioGUI.NewProjectForms.FeaturesForms
{
    partial class FeatureForm
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
            buttonNext = new Button();
            buttonReturn = new Button();
            SuspendLayout();
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(427, 272);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(94, 29);
            buttonNext.TabIndex = 0;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(539, 272);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(94, 29);
            buttonReturn.TabIndex = 1;
            buttonReturn.Text = "Return";
            buttonReturn.TextAlign = ContentAlignment.TopCenter;
            buttonReturn.UseVisualStyleBackColor = true;
            // 
            // FeatureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 323);
            Controls.Add(buttonReturn);
            Controls.Add(buttonNext);
            Name = "FeatureForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNext;
        private Button buttonReturn;
    }
}