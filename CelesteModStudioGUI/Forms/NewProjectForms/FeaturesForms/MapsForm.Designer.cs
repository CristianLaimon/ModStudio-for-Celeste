namespace CelesteModStudioGUI.NewProjectForms.FeaturesForms
{
    partial class MapsForm
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
            label1 = new Label();
            textBoxCampaignName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 140);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 2;
            label1.Text = "Campaign Name:";
            // 
            // textBoxCampaignName
            // 
            textBoxCampaignName.Location = new Point(321, 133);
            textBoxCampaignName.Name = "textBoxCampaignName";
            textBoxCampaignName.Size = new Size(125, 27);
            textBoxCampaignName.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 323);
            Controls.Add(textBoxCampaignName);
            Controls.Add(label1);
            Name = "Form1";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(textBoxCampaignName, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCampaignName;
    }
}