
namespace NewProjectGUI.Forms
{
    partial class Dialogform
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
            checkBoxEnglish = new CheckBox();
            checkBoxSpanish = new CheckBox();
            groupBoxSelectDialog = new GroupBox();
            label1 = new Label();
            textBoxCustomDialog = new TextBox();
            label2 = new Label();
            groupBoxSelectDialog.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxEnglish
            // 
            checkBoxEnglish.AutoSize = true;
            checkBoxEnglish.Checked = true;
            checkBoxEnglish.CheckState = CheckState.Checked;
            checkBoxEnglish.Location = new Point(35, 38);
            checkBoxEnglish.Name = "checkBoxEnglish";
            checkBoxEnglish.Size = new Size(98, 24);
            checkBoxEnglish.TabIndex = 2;
            checkBoxEnglish.Text = "English.txt";
            checkBoxEnglish.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpanish
            // 
            checkBoxSpanish.AutoSize = true;
            checkBoxSpanish.Location = new Point(35, 68);
            checkBoxSpanish.Name = "checkBoxSpanish";
            checkBoxSpanish.Size = new Size(102, 24);
            checkBoxSpanish.TabIndex = 3;
            checkBoxSpanish.Text = "Spanish.txt";
            checkBoxSpanish.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelectDialog
            // 
            groupBoxSelectDialog.Controls.Add(label2);
            groupBoxSelectDialog.Controls.Add(textBoxCustomDialog);
            groupBoxSelectDialog.Controls.Add(label1);
            groupBoxSelectDialog.Controls.Add(checkBoxSpanish);
            groupBoxSelectDialog.Controls.Add(checkBoxEnglish);
            groupBoxSelectDialog.Location = new Point(49, 23);
            groupBoxSelectDialog.Name = "groupBoxSelectDialog";
            groupBoxSelectDialog.Size = new Size(499, 130);
            groupBoxSelectDialog.TabIndex = 4;
            groupBoxSelectDialog.TabStop = false;
            groupBoxSelectDialog.Text = "Language dialogs to include:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 23);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 4;
            label1.Text = "Custom Language:";
            // 
            // textBoxCustomDialog
            // 
            textBoxCustomDialog.Location = new Point(333, 56);
            textBoxCustomDialog.Name = "textBoxCustomDialog";
            textBoxCustomDialog.Size = new Size(131, 27);
            textBoxCustomDialog.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(324, 98);
            label2.Name = "label2";
            label2.Size = new Size(151, 17);
            label2.TabIndex = 6;
            label2.Text = "No need to include \".txt\"";
            // 
            // Dialogform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 229);
            Controls.Add(groupBoxSelectDialog);
            Name = "Dialogform";
            Text = "Custom Dialog Settings";
            Controls.SetChildIndex(groupBoxSelectDialog, 0);
            groupBoxSelectDialog.ResumeLayout(false);
            groupBoxSelectDialog.PerformLayout();
            ResumeLayout(false);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Size = base.Size;
        }

        #endregion

        private CheckBox checkBoxEnglish;
        private CheckBox checkBoxSpanish;
        private GroupBox groupBoxSelectDialog;
        private Label label1;
        private TextBox textBoxCustomDialog;
        private Label label2;
    }
}