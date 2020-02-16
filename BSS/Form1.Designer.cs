namespace BSS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Property set", 1, 1);
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Property set", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Property set", 1, 1);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.spltMain = new System.Windows.Forms.SplitContainer();
            this.splitIpsOps = new System.Windows.Forms.SplitContainer();
            this.splitIps = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.imageListButton = new System.Windows.Forms.ImageList(this.components);
            this.btvAddChild = new System.Windows.Forms.Button();
            this.btnAddProp = new System.Windows.Forms.Button();
            this.txtPropValue = new System.Windows.Forms.TextBox();
            this.txtPropName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tvIps = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tvOps = new System.Windows.Forms.TreeView();
            this.tvLog = new System.Windows.Forms.TreeView();
            this.btnCloseIpsInputForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRun = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlMain.SuspendLayout();
            this.spltMain.Panel1.SuspendLayout();
            this.spltMain.Panel2.SuspendLayout();
            this.spltMain.SuspendLayout();
            this.splitIpsOps.Panel1.SuspendLayout();
            this.splitIpsOps.Panel2.SuspendLayout();
            this.splitIpsOps.SuspendLayout();
            this.splitIps.Panel1.SuspendLayout();
            this.splitIps.Panel2.SuspendLayout();
            this.splitIps.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.spltMain);
            this.pnlMain.Location = new System.Drawing.Point(-1, 78);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(634, 423);
            this.pnlMain.TabIndex = 35;
            // 
            // spltMain
            // 
            this.spltMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltMain.Location = new System.Drawing.Point(0, 0);
            this.spltMain.Name = "spltMain";
            // 
            // spltMain.Panel1
            // 
            this.spltMain.Panel1.Controls.Add(this.splitIpsOps);
            // 
            // spltMain.Panel2
            // 
            this.spltMain.Panel2.Controls.Add(this.tvLog);
            this.spltMain.Panel2MinSize = 5;
            this.spltMain.Size = new System.Drawing.Size(634, 423);
            this.spltMain.SplitterDistance = 473;
            this.spltMain.TabIndex = 0;
            this.spltMain.TabStop = false;
            // 
            // splitIpsOps
            // 
            this.splitIpsOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitIpsOps.Location = new System.Drawing.Point(0, 0);
            this.splitIpsOps.Name = "splitIpsOps";
            // 
            // splitIpsOps.Panel1
            // 
            this.splitIpsOps.Panel1.Controls.Add(this.splitIps);
            this.splitIpsOps.Panel1MinSize = 5;
            // 
            // splitIpsOps.Panel2
            // 
            this.splitIpsOps.Panel2.Controls.Add(this.tvOps);
            this.splitIpsOps.Panel2MinSize = 5;
            this.splitIpsOps.Size = new System.Drawing.Size(473, 423);
            this.splitIpsOps.SplitterDistance = 238;
            this.splitIpsOps.TabIndex = 0;
            this.splitIpsOps.TabStop = false;
            this.splitIpsOps.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitIpsOps_SplitterMoved);
            // 
            // splitIps
            // 
            this.splitIps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitIps.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitIps.IsSplitterFixed = true;
            this.splitIps.Location = new System.Drawing.Point(0, 0);
            this.splitIps.Name = "splitIps";
            this.splitIps.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitIps.Panel1
            // 
            this.splitIps.Panel1.Controls.Add(this.button1);
            this.splitIps.Panel1.Controls.Add(this.btvAddChild);
            this.splitIps.Panel1.Controls.Add(this.btnAddProp);
            this.splitIps.Panel1.Controls.Add(this.txtPropValue);
            this.splitIps.Panel1.Controls.Add(this.txtPropName);
            this.splitIps.Panel1.Controls.Add(this.label4);
            this.splitIps.Panel1.Controls.Add(this.label3);
            // 
            // splitIps.Panel2
            // 
            this.splitIps.Panel2.Controls.Add(this.tvIps);
            this.splitIps.Size = new System.Drawing.Size(238, 423);
            this.splitIps.SplitterDistance = 82;
            this.splitIps.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.imageListButton;
            this.button1.Location = new System.Drawing.Point(162, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 80;
            this.button1.Text = "&Delete";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageListButton
            // 
            this.imageListButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton.ImageStream")));
            this.imageListButton.TransparentColor = System.Drawing.Color.Lime;
            this.imageListButton.Images.SetKeyName(0, "");
            this.imageListButton.Images.SetKeyName(1, "");
            this.imageListButton.Images.SetKeyName(2, "");
            this.imageListButton.Images.SetKeyName(3, "");
            // 
            // btvAddChild
            // 
            this.btvAddChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btvAddChild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvAddChild.ImageIndex = 1;
            this.btvAddChild.ImageList = this.imageListButton;
            this.btvAddChild.Location = new System.Drawing.Point(81, 55);
            this.btvAddChild.Name = "btvAddChild";
            this.btvAddChild.Size = new System.Drawing.Size(75, 23);
            this.btvAddChild.TabIndex = 70;
            this.btvAddChild.Text = "Add &Child";
            this.btvAddChild.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btvAddChild.UseVisualStyleBackColor = true;
            this.btvAddChild.Click += new System.EventHandler(this.btvAddChild_Click);
            // 
            // btnAddProp
            // 
            this.btnAddProp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProp.ImageIndex = 0;
            this.btnAddProp.ImageList = this.imageListButton;
            this.btnAddProp.Location = new System.Drawing.Point(0, 55);
            this.btnAddProp.Name = "btnAddProp";
            this.btnAddProp.Size = new System.Drawing.Size(75, 23);
            this.btnAddProp.TabIndex = 60;
            this.btnAddProp.Text = "&Add prop";
            this.btnAddProp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProp.UseVisualStyleBackColor = true;
            this.btnAddProp.Click += new System.EventHandler(this.btnAddProp_Click);
            // 
            // txtPropValue
            // 
            this.txtPropValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPropValue.Location = new System.Drawing.Point(43, 29);
            this.txtPropValue.Name = "txtPropValue";
            this.txtPropValue.Size = new System.Drawing.Size(192, 20);
            this.txtPropValue.TabIndex = 50;
            // 
            // txtPropName
            // 
            this.txtPropName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPropName.Location = new System.Drawing.Point(74, 8);
            this.txtPropName.Name = "txtPropName";
            this.txtPropName.Size = new System.Drawing.Size(161, 20);
            this.txtPropName.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name/Type";
            // 
            // tvIps
            // 
            this.tvIps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvIps.ImageIndex = 0;
            this.tvIps.ImageList = this.imageList;
            this.tvIps.Location = new System.Drawing.Point(0, 0);
            this.tvIps.Name = "tvIps";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node0";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Property set";
            this.tvIps.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvIps.SelectedImageIndex = 0;
            this.tvIps.Size = new System.Drawing.Size(238, 337);
            this.tvIps.TabIndex = 0;
            this.tvIps.DoubleClick += new System.EventHandler(this.tvIps_DoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Lime;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            // 
            // tvOps
            // 
            this.tvOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOps.ImageIndex = 0;
            this.tvOps.ImageList = this.imageList;
            this.tvOps.Location = new System.Drawing.Point(0, 0);
            this.tvOps.Name = "tvOps";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node0";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Property set";
            this.tvOps.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvOps.SelectedImageIndex = 0;
            this.tvOps.Size = new System.Drawing.Size(231, 423);
            this.tvOps.TabIndex = 0;
            this.tvOps.DoubleClick += new System.EventHandler(this.tvOps_DoubleClick);
            // 
            // tvLog
            // 
            this.tvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLog.ImageIndex = 0;
            this.tvLog.ImageList = this.imageList;
            this.tvLog.Location = new System.Drawing.Point(0, 0);
            this.tvLog.Name = "tvLog";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node0";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Property set";
            this.tvLog.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvLog.SelectedImageIndex = 0;
            this.tvLog.Size = new System.Drawing.Size(157, 423);
            this.tvLog.TabIndex = 0;
            this.tvLog.DoubleClick += new System.EventHandler(this.tvLog_DoubleClick);
            // 
            // btnCloseIpsInputForm
            // 
            this.btnCloseIpsInputForm.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.btnCloseIpsInputForm.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnCloseIpsInputForm.Location = new System.Drawing.Point(-1, 75);
            this.btnCloseIpsInputForm.Name = "btnCloseIpsInputForm";
            this.btnCloseIpsInputForm.Size = new System.Drawing.Size(242, 5);
            this.btnCloseIpsInputForm.TabIndex = 0;
            this.btnCloseIpsInputForm.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCloseIpsInputForm, "Close form");
            this.btnCloseIpsInputForm.UseVisualStyleBackColor = true;
            this.btnCloseIpsInputForm.Click += new System.EventHandler(this.btnCloseIpsInputForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Function";
            // 
            // txtService
            // 
            this.txtService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtService.Location = new System.Drawing.Point(51, 26);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(515, 20);
            this.txtService.TabIndex = 10;
            // 
            // txtFunction
            // 
            this.txtFunction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFunction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFunction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFunction.Location = new System.Drawing.Point(51, 52);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(515, 20);
            this.txtFunction.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miExit
            // 
            this.miExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(35, 20);
            this.miExit.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRun.ImageIndex = 3;
            this.btnRun.ImageList = this.imageListButton;
            this.btnRun.Location = new System.Drawing.Point(572, 26);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(58, 46);
            this.btnRun.TabIndex = 30;
            this.btnRun.Text = "&Run";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "BSS-xml| *.BSS.xml|*.xml|*.xml|*.*|*.*";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "BSS-xml| *.BSS.xml|*.xml|*.xml|*.*|*.*";
            this.openFileDialog1.Title = "Load";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 503);
            this.Controls.Add(this.btnCloseIpsInputForm);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Siebel BS Simulator";
            this.pnlMain.ResumeLayout(false);
            this.spltMain.Panel1.ResumeLayout(false);
            this.spltMain.Panel2.ResumeLayout(false);
            this.spltMain.ResumeLayout(false);
            this.splitIpsOps.Panel1.ResumeLayout(false);
            this.splitIpsOps.Panel2.ResumeLayout(false);
            this.splitIpsOps.ResumeLayout(false);
            this.splitIps.Panel1.ResumeLayout(false);
            this.splitIps.Panel1.PerformLayout();
            this.splitIps.Panel2.ResumeLayout(false);
            this.splitIps.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer spltMain;
        private System.Windows.Forms.SplitContainer splitIpsOps;
        private System.Windows.Forms.TreeView tvIps;
        private System.Windows.Forms.TreeView tvOps;
        private System.Windows.Forms.TreeView tvLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ImageList imageListButton;
        private System.Windows.Forms.SplitContainer splitIps;
        private System.Windows.Forms.Button btnAddProp;
        private System.Windows.Forms.TextBox txtPropValue;
        private System.Windows.Forms.TextBox txtPropName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btvAddChild;
        private System.Windows.Forms.Button btnCloseIpsInputForm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;


    }
}

