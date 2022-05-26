namespace FileExplorerXD
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
            this.dirsTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.refresh_button = new System.Windows.Forms.Button();
            this.up_button = new System.Windows.Forms.Button();
            this.forward_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.itemCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dirsTreeView
            // 
            this.dirsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dirsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dirsTreeView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirsTreeView.HideSelection = false;
            this.dirsTreeView.Location = new System.Drawing.Point(0, 48);
            this.dirsTreeView.Name = "dirsTreeView";
            this.dirsTreeView.ShowLines = false;
            this.dirsTreeView.Size = new System.Drawing.Size(171, 496);
            this.dirsTreeView.TabIndex = 0;
            this.dirsTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.dirsTreeView_BeforeExpand);
            this.dirsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dirsTreeView_AfterSelect);
            this.dirsTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dirsTreeView_NodeMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.path_textBox);
            this.panel1.Controls.Add(this.refresh_button);
            this.panel1.Controls.Add(this.up_button);
            this.panel1.Controls.Add(this.forward_button);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 48);
            this.panel1.TabIndex = 3;
            // 
            // path_textBox
            // 
            this.path_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_textBox.Location = new System.Drawing.Point(104, 10);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(504, 23);
            this.path_textBox.TabIndex = 0;
            this.path_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.path_textBox_KeyDown);
            // 
            // refresh_button
            // 
            this.refresh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_button.Location = new System.Drawing.Point(616, 8);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(28, 28);
            this.refresh_button.TabIndex = 4;
            this.refresh_button.Text = "🗘";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // up_button
            // 
            this.up_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_button.Location = new System.Drawing.Point(72, 8);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(28, 28);
            this.up_button.TabIndex = 3;
            this.up_button.Text = "ᐱ";
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // forward_button
            // 
            this.forward_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forward_button.Location = new System.Drawing.Point(40, 8);
            this.forward_button.Name = "forward_button";
            this.forward_button.Size = new System.Drawing.Size(28, 28);
            this.forward_button.TabIndex = 2;
            this.forward_button.Text = "＞";
            this.forward_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forward_button.UseVisualStyleBackColor = true;
            this.forward_button.Click += new System.EventHandler(this.forward_button_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(8, 8);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(28, 28);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "＜";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dirsTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(654, 542);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 4;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 48);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(478, 496);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "unknown.png");
            this.imageList1.Images.SetKeyName(1, "NoRootDirectory.png");
            this.imageList1.Images.SetKeyName(2, "removable.png");
            this.imageList1.Images.SetKeyName(3, "fixed.png");
            this.imageList1.Images.SetKeyName(4, "network.png");
            this.imageList1.Images.SetKeyName(5, "CDRom.png");
            this.imageList1.Images.SetKeyName(6, "RAM.png");
            this.imageList1.Images.SetKeyName(7, "locked.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCountStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(654, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // itemCountStatusLabel
            // 
            this.itemCountStatusLabel.Name = "itemCountStatusLabel";
            this.itemCountStatusLabel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.itemCountStatusLabel.Size = new System.Drawing.Size(78, 17);
            this.itemCountStatusLabel.Text = "FileCount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FileExplorerXD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView dirsTreeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox path_textBox;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button forward_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel itemCountStatusLabel;
    }
}

