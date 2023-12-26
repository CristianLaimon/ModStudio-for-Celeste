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
            treeViewFiles = new TreeView();
            imageListTreeView = new ImageList(components);
            PanelWithTabControl = new Panel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            addToolStripMenuItem = new ToolStripMenuItem();
            statusStripFooter.SuspendLayout();
            toolStripHeader.SuspendLayout();
            PanelWithTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
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
            toolStripDropDownButtonNew.DropDownItems.AddRange(new ToolStripItem[] { createNewModProyectToolStripMenuItem1, addToolStripMenuItem });
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
            createNewModProyectToolStripMenuItem1.Click += createNewModButton;
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
            openExistingProyectToolStripMenuItem.Click += openExistingModButton;
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
            // treeViewFiles
            // 
            treeViewFiles.Dock = DockStyle.Fill;
            treeViewFiles.ImageIndex = 0;
            treeViewFiles.ImageList = imageListTreeView;
            treeViewFiles.Location = new Point(0, 0);
            treeViewFiles.Name = "treeViewFiles";
            treeViewFiles.SelectedImageIndex = 0;
            treeViewFiles.Size = new Size(178, 571);
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
            imageListTreeView.Images.SetKeyName(4, "Strawberry_ingame.png");
            // 
            // PanelWithTabControl
            // 
            PanelWithTabControl.Controls.Add(splitContainer1);
            PanelWithTabControl.Dock = DockStyle.Fill;
            PanelWithTabControl.Location = new Point(0, 27);
            PanelWithTabControl.Name = "PanelWithTabControl";
            PanelWithTabControl.Size = new Size(1069, 571);
            PanelWithTabControl.TabIndex = 5;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeViewFiles);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1069, 571);
            splitContainer1.SplitterDistance = 178;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tabControl1);
            splitContainer2.Size = new Size(887, 571);
            splitContainer2.SplitterDistance = 672;
            splitContainer2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(672, 571);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(664, 538);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Blank Project";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(255, 26);
            addToolStripMenuItem.Text = "New map";
            addToolStripMenuItem.Click += NewMapButton;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 624);
            Controls.Add(PanelWithTabControl);
            Controls.Add(toolStripHeader);
            Controls.Add(statusStripFooter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "ModStudio for Celeste";
            statusStripFooter.ResumeLayout(false);
            statusStripFooter.PerformLayout();
            toolStripHeader.ResumeLayout(false);
            toolStripHeader.PerformLayout();
            PanelWithTabControl.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
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
        private Panel PanelWithTabControl;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TreeView treeViewFiles;
        private ImageList imageListTreeView;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ToolStripMenuItem addToolStripMenuItem;
    }
}
