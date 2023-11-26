namespace ModStudio_for_Celeste
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelStatus = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButtonNew = new ToolStripDropDownButton();
            createNewModProyectToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripDropDownButtonOpen = new ToolStripDropDownButton();
            openExistingProyectToolStripMenuItem = new ToolStripMenuItem();
            createNewModProyectToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButtonNew = new ToolStripSplitButton();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelStatus });
            statusStrip1.Location = new Point(0, 502);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(978, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            toolStripStatusLabelStatus.Size = new Size(179, 20);
            toolStripStatusLabelStatus.Text = "--- Startup Completed ---";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButtonNew, toolStripDropDownButtonOpen });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(978, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonNew
            // 
            toolStripDropDownButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonNew.DropDownItems.AddRange(new ToolStripItem[] { createNewModProyectToolStripMenuItem1 });
            toolStripDropDownButtonNew.Image = (Image)resources.GetObject("toolStripDropDownButtonNew.Image");
            toolStripDropDownButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonNew.Name = "toolStripDropDownButtonNew";
            toolStripDropDownButtonNew.Size = new Size(53, 24);
            toolStripDropDownButtonNew.Text = "New";
            // 
            // createNewModProyectToolStripMenuItem1
            // 
            createNewModProyectToolStripMenuItem1.Name = "createNewModProyectToolStripMenuItem1";
            createNewModProyectToolStripMenuItem1.Size = new Size(255, 26);
            createNewModProyectToolStripMenuItem1.Text = "Create new mod proyect";
            createNewModProyectToolStripMenuItem1.Click += createNewModProyectToolStripMenuItem1_Click;
            // 
            // toolStripDropDownButtonOpen
            // 
            toolStripDropDownButtonOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonOpen.DropDownItems.AddRange(new ToolStripItem[] { openExistingProyectToolStripMenuItem });
            toolStripDropDownButtonOpen.Image = (Image)resources.GetObject("toolStripDropDownButtonOpen.Image");
            toolStripDropDownButtonOpen.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonOpen.Name = "toolStripDropDownButtonOpen";
            toolStripDropDownButtonOpen.Size = new Size(59, 24);
            toolStripDropDownButtonOpen.Text = "Open";
            // 
            // openExistingProyectToolStripMenuItem
            // 
            openExistingProyectToolStripMenuItem.Name = "openExistingProyectToolStripMenuItem";
            openExistingProyectToolStripMenuItem.Size = new Size(246, 26);
            openExistingProyectToolStripMenuItem.Text = "Open existing proyect...";
            openExistingProyectToolStripMenuItem.Click += openExistingProyectToolStripMenuItem_Click;
            // 
            // createNewModProyectToolStripMenuItem
            // 
            createNewModProyectToolStripMenuItem.Name = "createNewModProyectToolStripMenuItem";
            createNewModProyectToolStripMenuItem.Size = new Size(226, 26);
            createNewModProyectToolStripMenuItem.Text = "Create new project...";
            // 
            // toolStripSplitButtonNew
            // 
            toolStripSplitButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButtonNew.DropDownItems.AddRange(new ToolStripItem[] { createNewModProyectToolStripMenuItem });
            toolStripSplitButtonNew.Image = (Image)resources.GetObject("toolStripSplitButtonNew.Image");
            toolStripSplitButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripSplitButtonNew.Name = "toolStripSplitButtonNew";
            toolStripSplitButtonNew.Size = new Size(58, 24);
            toolStripSplitButtonNew.Text = "New";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 528);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Name = "Main";
            Text = "ModStudio for Celeste";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelStatus;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButtonOpen;
        private ToolStripMenuItem openExistingProyectToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButtonNew;
        private ToolStripMenuItem createNewModProyectToolStripMenuItem1;
        private ToolStripMenuItem createNewModProyectToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButtonNew;
    }
}
