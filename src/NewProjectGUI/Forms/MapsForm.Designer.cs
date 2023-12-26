namespace NewProjectGUI.Forms
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
        private new void InitializeComponent()
        {
            label1 = new Label();
            textBoxCampaignName = new TextBox();
            label2 = new Label();
            textBoxFirstMapName = new TextBox();
            labelError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 68);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 2;
            label1.Text = "Campaign Name:";
            // 
            // textBoxCampaignName
            // 
            textBoxCampaignName.Location = new Point(319, 65);
            textBoxCampaignName.Name = "textBoxCampaignName";
            textBoxCampaignName.Size = new Size(125, 27);
            textBoxCampaignName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 109);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 4;
            label2.Text = "First Map Name:";
            // 
            // textBoxFirstMapName
            // 
            textBoxFirstMapName.Location = new Point(319, 109);
            textBoxFirstMapName.Name = "textBoxFirstMapName";
            textBoxFirstMapName.Size = new Size(125, 27);
            textBoxFirstMapName.TabIndex = 5;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Brown;
            labelError.Location = new Point(236, 153);
            labelError.Name = "labelError";
            labelError.Size = new Size(103, 20);
            labelError.TabIndex = 6;
            labelError.Text = "DEBUGERROR";
            // 
            // MapsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 229);
            Controls.Add(labelError);
            Controls.Add(textBoxFirstMapName);
            Controls.Add(label2);
            Controls.Add(textBoxCampaignName);
            Controls.Add(label1);
            Name = "MapsForm";
            ShowInTaskbar = false;
            Text = "Maps Setting";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(textBoxCampaignName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(textBoxFirstMapName, 0);
            Controls.SetChildIndex(labelError, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCampaignName;
        private Label label2;
        private TextBox textBoxFirstMapName;
        private Label labelError;
    }
}