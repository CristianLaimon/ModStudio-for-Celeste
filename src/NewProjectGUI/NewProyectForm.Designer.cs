namespace CelesteModStudioGUI
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
            buttonOk = new Button();
            buttonCancel = new Button();
            statusStripStatus = new StatusStrip();
            stripLabelActualStatus = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            checkBoxGraphics = new CheckBox();
            checkBoxDialog = new CheckBox();
            checkBoxMaps = new CheckBox();
            checkBoxAhorn = new CheckBox();
            checkBoxLoenn = new CheckBox();
            groupBox2 = new GroupBox();
            statusStripStatus.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDirectorySelected
            // 
            textBoxDirectorySelected.Location = new Point(148, 26);
            textBoxDirectorySelected.Name = "textBoxDirectorySelected";
            textBoxDirectorySelected.ReadOnly = true;
            textBoxDirectorySelected.Size = new Size(217, 27);
            textBoxDirectorySelected.TabIndex = 0;
            // 
            // labelSelectDirectory
            // 
            labelSelectDirectory.AutoSize = true;
            labelSelectDirectory.Location = new Point(20, 29);
            labelSelectDirectory.Name = "labelSelectDirectory";
            labelSelectDirectory.Size = new Size(115, 20);
            labelSelectDirectory.TabIndex = 1;
            labelSelectDirectory.Text = "Parent Directory";
            // 
            // buttonSelectNewDirectory
            // 
            buttonSelectNewDirectory.Location = new Point(379, 24);
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
            // buttonOk
            // 
            buttonOk.Location = new Point(242, 376);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(68, 34);
            buttonOk.TabIndex = 9;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(316, 376);
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
            statusStripStatus.Location = new Point(0, 416);
            statusStripStatus.Name = "statusStripStatus";
            statusStripStatus.Size = new Size(432, 22);
            statusStripStatus.TabIndex = 11;
            statusStripStatus.Text = "statusStrip1";
            // 
            // stripLabelActualStatus
            // 
            stripLabelActualStatus.Name = "stripLabelActualStatus";
            stripLabelActualStatus.Size = new Size(0, 16);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxGraphics);
            groupBox1.Controls.Add(checkBoxDialog);
            groupBox1.Controls.Add(checkBoxMaps);
            groupBox1.Location = new Point(32, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 156);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Basic Mod Features";
            // 
            // checkBoxGraphics
            // 
            checkBoxGraphics.AutoSize = true;
            checkBoxGraphics.Location = new Point(23, 97);
            checkBoxGraphics.Name = "checkBoxGraphics";
            checkBoxGraphics.Size = new Size(88, 24);
            checkBoxGraphics.TabIndex = 2;
            checkBoxGraphics.Text = "Graphics";
            checkBoxGraphics.UseVisualStyleBackColor = true;
            // 
            // checkBoxDialog
            // 
            checkBoxDialog.AutoSize = true;
            checkBoxDialog.Location = new Point(23, 67);
            checkBoxDialog.Name = "checkBoxDialog";
            checkBoxDialog.Size = new Size(76, 24);
            checkBoxDialog.TabIndex = 1;
            checkBoxDialog.Text = "Dialog";
            checkBoxDialog.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaps
            // 
            checkBoxMaps.AutoSize = true;
            checkBoxMaps.Location = new Point(23, 37);
            checkBoxMaps.Name = "checkBoxMaps";
            checkBoxMaps.Size = new Size(67, 24);
            checkBoxMaps.TabIndex = 0;
            checkBoxMaps.Text = "Maps";
            checkBoxMaps.UseVisualStyleBackColor = true;
            // 
            // checkBoxAhorn
            // 
            checkBoxAhorn.AutoSize = true;
            checkBoxAhorn.Location = new Point(23, 69);
            checkBoxAhorn.Name = "checkBoxAhorn";
            checkBoxAhorn.Size = new Size(71, 24);
            checkBoxAhorn.TabIndex = 3;
            checkBoxAhorn.Text = "Ahorn";
            checkBoxAhorn.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoenn
            // 
            checkBoxLoenn.AutoSize = true;
            checkBoxLoenn.Location = new Point(23, 39);
            checkBoxLoenn.Name = "checkBoxLoenn";
            checkBoxLoenn.Size = new Size(71, 24);
            checkBoxLoenn.TabIndex = 4;
            checkBoxLoenn.Text = "Loenn";
            checkBoxLoenn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxLoenn);
            groupBox2.Controls.Add(checkBoxAhorn);
            groupBox2.Location = new Point(211, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(176, 156);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Advanced Features";
            // 
            // NewProyectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 438);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStripStatus);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Button buttonOk;
        private Button buttonCancel;
        private StatusStrip statusStripStatus;
        private ToolStripStatusLabel stripLabelActualStatus;
        private GroupBox groupBox1;
        private CheckBox checkBoxDialog;
        private CheckBox checkBoxMaps;
        private CheckBox checkBoxLoenn;
        private CheckBox checkBoxAhorn;
        private CheckBox checkBoxGraphics;
        private GroupBox groupBox2;
    }
}