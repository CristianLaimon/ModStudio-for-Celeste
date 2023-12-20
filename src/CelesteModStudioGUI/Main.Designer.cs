namespace CelesteModStudioGUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStripFooter = new StatusStrip();
            toolStripStatusLabelStatus = new ToolStripStatusLabel();
            toolStripHeader = new ToolStrip();
            toolStripDropDownButtonNew = new ToolStripDropDownButton();
            createNewModProyectToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripDropDownButtonOpen = new ToolStripDropDownButton();
            openExistingProyectToolStripMenuItem = new ToolStripMenuItem();
            createNewModProyectToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButtonNew = new ToolStripSplitButton();
            LeftPanel = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            treeViewFiles = new TreeView();
            imageListTreeView = new ImageList(components);
            RightPanel = new Panel();
            PanelWithTabControl = new Panel();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            statusStripFooter.SuspendLayout();
            toolStripHeader.SuspendLayout();
            LeftPanel.SuspendLayout();
            panel1.SuspendLayout();
            PanelWithTabControl.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStripFooter
            // 
            statusStripFooter.ImageScalingSize = new Size(20, 20);
            statusStripFooter.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelStatus });
            statusStripFooter.Location = new Point(0, 598);
            statusStripFooter.Name = "statusStripFooter";
            statusStripFooter.Size = new Size(1069, 26);
            statusStripFooter.TabIndex = 0;
            statusStripFooter.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            toolStripStatusLabelStatus.Size = new Size(179, 20);
            toolStripStatusLabelStatus.Text = "--- Startup Completed ---";
            // 
            // toolStripHeader
            // 
            toolStripHeader.ImageScalingSize = new Size(20, 20);
            toolStripHeader.Items.AddRange(new ToolStripItem[] { toolStripDropDownButtonNew, toolStripDropDownButtonOpen });
            toolStripHeader.Location = new Point(0, 0);
            toolStripHeader.Name = "toolStripHeader";
            toolStripHeader.Size = new Size(1069, 27);
            toolStripHeader.TabIndex = 1;
            toolStripHeader.Text = "toolStrip1";
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
            // LeftPanel
            // 
            LeftPanel.Controls.Add(panel1);
            LeftPanel.Controls.Add(treeViewFiles);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 27);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(168, 571);
            LeftPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 31);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Files";
            // 
            // treeViewFiles
            // 
            treeViewFiles.ImageIndex = 0;
            treeViewFiles.ImageList = imageListTreeView;
            treeViewFiles.Location = new Point(0, 32);
            treeViewFiles.Name = "treeViewFiles";
            treeViewFiles.SelectedImageIndex = 0;
            treeViewFiles.Size = new Size(168, 539);
            treeViewFiles.TabIndex = 0;
            // 
            // imageListTreeView
            // 
            imageListTreeView.ColorDepth = ColorDepth.Depth32Bit;
            imageListTreeView.ImageStream = (ImageListStreamer)resources.GetObject("imageListTreeView.ImageStream");
            imageListTreeView.TransparentColor = Color.Transparent;
            imageListTreeView.Images.SetKeyName(0, "default.png");
            imageListTreeView.Images.SetKeyName(1, "folder.png");
            imageListTreeView.Images.SetKeyName(2, "yaml.png");
            imageListTreeView.Images.SetKeyName(3, "grengem.png");
            // 
            // RightPanel
            // 
            RightPanel.Dock = DockStyle.Right;
            RightPanel.Location = new Point(865, 27);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(204, 571);
            RightPanel.TabIndex = 4;
            // 
            // PanelWithTabControl
            // 
            PanelWithTabControl.Controls.Add(tabControl1);
            PanelWithTabControl.Dock = DockStyle.Fill;
            PanelWithTabControl.Location = new Point(168, 27);
            PanelWithTabControl.Name = "PanelWithTabControl";
            PanelWithTabControl.Size = new Size(697, 571);
            PanelWithTabControl.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(697, 571);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(689, 538);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Blank Project";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 624);
            Controls.Add(PanelWithTabControl);
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            Controls.Add(toolStripHeader);
            Controls.Add(statusStripFooter);
            Name = "Main";
            Text = "ModStudio for Celeste";
            statusStripFooter.ResumeLayout(false);
            statusStripFooter.PerformLayout();
            toolStripHeader.ResumeLayout(false);
            toolStripHeader.PerformLayout();
            LeftPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelWithTabControl.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStripFooter;
        private ToolStripStatusLabel toolStripStatusLabelStatus;
        private ToolStrip toolStripHeader;
        private ToolStripDropDownButton toolStripDropDownButtonOpen;
        private ToolStripMenuItem openExistingProyectToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButtonNew;
        private ToolStripMenuItem createNewModProyectToolStripMenuItem1;
        private ToolStripMenuItem createNewModProyectToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButtonNew;
        private Panel LeftPanel;
        private Panel RightPanel;
        private Panel PanelWithTabControl;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Panel panel1;
        private TreeView treeViewFiles;
        private Label label1;
        private ImageList imageListTreeView;
    }
}
