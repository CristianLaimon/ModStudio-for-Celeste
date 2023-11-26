namespace ModStudio_for_Celeste
{
    partial class NewProyectForm
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
            textBoxDirectorySelected = new TextBox();
            labelSelectDirectory = new Label();
            buttonSelectNewDirectory = new Button();
            labelModName = new Label();
            label2 = new Label();
            textBoxModName = new TextBox();
            textBoxUsernameMod = new TextBox();
            labelCampaignName = new Label();
            textBoxCampaignName = new TextBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            statusStripStatus = new StatusStrip();
            stripLabelActualStatus = new ToolStripStatusLabel();
            statusStripStatus.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDirectorySelected
            // 
            textBoxDirectorySelected.Location = new Point(120, 26);
            textBoxDirectorySelected.Name = "textBoxDirectorySelected";
            textBoxDirectorySelected.ReadOnly = true;
            textBoxDirectorySelected.Size = new Size(217, 27);
            textBoxDirectorySelected.TabIndex = 0;
            // 
            // labelSelectDirectory
            // 
            labelSelectDirectory.AutoSize = true;
            labelSelectDirectory.Location = new Point(20, 26);
            labelSelectDirectory.Name = "labelSelectDirectory";
            labelSelectDirectory.Size = new Size(70, 20);
            labelSelectDirectory.TabIndex = 1;
            labelSelectDirectory.Text = "Directory";
            // 
            // buttonSelectNewDirectory
            // 
            buttonSelectNewDirectory.Location = new Point(357, 26);
            buttonSelectNewDirectory.Name = "buttonSelectNewDirectory";
            buttonSelectNewDirectory.Size = new Size(37, 31);
            buttonSelectNewDirectory.TabIndex = 2;
            buttonSelectNewDirectory.Text = "...";
            buttonSelectNewDirectory.UseVisualStyleBackColor = true;
            buttonSelectNewDirectory.Click += buttonSelectNewDirectory_Click;
            // 
            // labelModName
            // 
            labelModName.AutoSize = true;
            labelModName.Location = new Point(20, 64);
            labelModName.Name = "labelModName";
            labelModName.Size = new Size(84, 20);
            labelModName.TabIndex = 3;
            labelModName.Text = "Mod Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 107);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 4;
            label2.Text = "Author/Creator Name";
            // 
            // textBoxModName
            // 
            textBoxModName.Location = new Point(120, 64);
            textBoxModName.Name = "textBoxModName";
            textBoxModName.Size = new Size(217, 27);
            textBoxModName.TabIndex = 5;
            // 
            // textBoxUsernameMod
            // 
            textBoxUsernameMod.Location = new Point(179, 107);
            textBoxUsernameMod.Name = "textBoxUsernameMod";
            textBoxUsernameMod.Size = new Size(158, 27);
            textBoxUsernameMod.TabIndex = 6;
            // 
            // labelCampaignName
            // 
            labelCampaignName.AutoSize = true;
            labelCampaignName.Location = new Point(21, 152);
            labelCampaignName.Name = "labelCampaignName";
            labelCampaignName.Size = new Size(121, 20);
            labelCampaignName.TabIndex = 7;
            labelCampaignName.Text = "Campaign Name";
            // 
            // textBoxCampaignName
            // 
            textBoxCampaignName.Location = new Point(148, 149);
            textBoxCampaignName.Name = "textBoxCampaignName";
            textBoxCampaignName.Size = new Size(189, 27);
            textBoxCampaignName.TabIndex = 8;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(218, 227);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(68, 34);
            buttonOk.TabIndex = 9;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(306, 227);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 34);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // statusStripStatus
            // 
            statusStripStatus.ImageScalingSize = new Size(20, 20);
            statusStripStatus.Items.AddRange(new ToolStripItem[] { stripLabelActualStatus });
            statusStripStatus.Location = new Point(0, 295);
            statusStripStatus.Name = "statusStripStatus";
            statusStripStatus.Size = new Size(428, 22);
            statusStripStatus.TabIndex = 11;
            statusStripStatus.Text = "statusStrip1";
            // 
            // stripLabelActualStatus
            // 
            stripLabelActualStatus.Name = "stripLabelActualStatus";
            stripLabelActualStatus.Size = new Size(0, 16);
            // 
            // NewProyectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 317);
            Controls.Add(statusStripStatus);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(textBoxCampaignName);
            Controls.Add(labelCampaignName);
            Controls.Add(textBoxUsernameMod);
            Controls.Add(textBoxModName);
            Controls.Add(label2);
            Controls.Add(labelModName);
            Controls.Add(buttonSelectNewDirectory);
            Controls.Add(labelSelectDirectory);
            Controls.Add(textBoxDirectorySelected);
            Name = "NewProyectForm";
            Text = "Create new mod project...";
            statusStripStatus.ResumeLayout(false);
            statusStripStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDirectorySelected;
        private Label labelSelectDirectory;
        private Button buttonSelectNewDirectory;
        private Label labelModName;
        private Label label2;
        private TextBox textBoxModName;
        private TextBox textBoxUsernameMod;
        private Label labelCampaignName;
        private TextBox textBoxCampaignName;
        private Button buttonOk;
        private Button buttonCancel;
        private StatusStrip statusStripStatus;
        private ToolStripStatusLabel stripLabelActualStatus;
    }
}