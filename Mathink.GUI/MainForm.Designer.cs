namespace Mathink.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picOut = new System.Windows.Forms.PictureBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.slRet = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTxtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpyOutPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProgDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpWpfmath = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.buttonCopyClipboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpWpfmath.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picOut
            // 
            this.picOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picOut.BackColor = System.Drawing.SystemColors.Window;
            this.picOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOut.Location = new System.Drawing.Point(9, 178);
            this.picOut.Name = "picOut";
            this.picOut.Padding = new System.Windows.Forms.Padding(8);
            this.picOut.Size = new System.Drawing.Size(310, 131);
            this.picOut.TabIndex = 0;
            this.picOut.TabStop = false;
            // 
            // txtIn
            // 
            this.txtIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIn.Location = new System.Drawing.Point(6, 35);
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtIn.Size = new System.Drawing.Size(313, 100);
            this.txtIn.TabIndex = 1;
            this.txtIn.Text = "\\vec{x}=\\frac{1}{2}\\vec{a}t^2";
            this.txtIn.TextChanged += new System.EventHandler(this.txtIn_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preview";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Formula editor";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slErr,
            this.slRet});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(335, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slErr
            // 
            this.slErr.ForeColor = System.Drawing.Color.Red;
            this.slErr.Name = "slErr";
            this.slErr.Size = new System.Drawing.Size(0, 17);
            // 
            // slRet
            // 
            this.slRet.Name = "slRet";
            this.slRet.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentToolStripMenuItem,
            this.editToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(335, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.documentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.documentToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.documentToolStripMenuItem.Text = "Document";
            this.documentToolStripMenuItem.Click += new System.EventHandler(this.documentToolStripMenuItem_Click);
            // 
            // 导入ToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.importToolStripMenuItem.Text = "Open";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePNGToolStripMenuItem,
            this.saveSVGToolStripMenuItem,
            this.saveTxtToolStripMenuItem1});
            this.saveAsToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // 保存图片ToolStripMenuItem
            // 
            this.savePNGToolStripMenuItem.Name = "保存图片ToolStripMenuItem";
            this.savePNGToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.savePNGToolStripMenuItem.Text = "Save as PNG";
            this.savePNGToolStripMenuItem.Click += new System.EventHandler(this.savePNGToolStripMenuItem_Click);
            // 
            // 保存SVGToolStripMenuItem
            // 
            this.saveSVGToolStripMenuItem.Name = "保存SVGToolStripMenuItem";
            this.saveSVGToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveSVGToolStripMenuItem.Text = "Save as SVG";
            this.saveSVGToolStripMenuItem.Click += new System.EventHandler(this.saveSVGToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem1
            // 
            this.saveTxtToolStripMenuItem1.Name = "保存ToolStripMenuItem1";
            this.saveTxtToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.saveTxtToolStripMenuItem1.Text = "Save as txt";
            this.saveTxtToolStripMenuItem1.Click += new System.EventHandler(this.saveTxtToolStripMenuItem1_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // 清空ToolStripMenuItem
            // 
            this.emptyToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.emptyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.emptyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.emptyToolStripMenuItem.Text = "Empty";
            this.emptyToolStripMenuItem.Click += new System.EventHandler(this.EmptyToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem,
            this.cpyOutPathToolStripMenuItem,
            this.openProgDirToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.帮助ToolStripMenuItem.Text = "Help";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.githubToolStripMenuItem.Text = "Github repo";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // 复制输出路径ToolStripMenuItem
            // 
            this.cpyOutPathToolStripMenuItem.Name = "复制输出路径ToolStripMenuItem";
            this.cpyOutPathToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cpyOutPathToolStripMenuItem.Text = "Copy output path";
            this.cpyOutPathToolStripMenuItem.Click += new System.EventHandler(this.cpyOutPath);
            // 
            // 打开程序目录ToolStripMenuItem
            // 
            this.openProgDirToolStripMenuItem.Name = "打开程序目录ToolStripMenuItem";
            this.openProgDirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.openProgDirToolStripMenuItem.Text = "Open the program directory";
            this.openProgDirToolStripMenuItem.Click += new System.EventHandler(this.openProgDir);
            // 
            // 关于ToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topWindowToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // 置顶窗口ToolStripMenuItem
            // 
            this.topWindowToolStripMenuItem.Checked = true;
            this.topWindowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topWindowToolStripMenuItem.Name = "置顶窗口ToolStripMenuItem";
            this.topWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.topWindowToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.topWindowToolStripMenuItem.Text = "Top window";
            this.topWindowToolStripMenuItem.Click += new System.EventHandler(this.TopWindowToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpWpfmath);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 376);
            this.tabControl1.TabIndex = 5;
            // 
            // tpWpfmath
            // 
            this.tpWpfmath.Controls.Add(this.buttonCopyClipboard);
            this.tpWpfmath.Controls.Add(this.txtIn);
            this.tpWpfmath.Controls.Add(this.picOut);
            this.tpWpfmath.Controls.Add(this.label1);
            this.tpWpfmath.Controls.Add(this.label2);
            this.tpWpfmath.Location = new System.Drawing.Point(4, 23);
            this.tpWpfmath.Name = "tpWpfmath";
            this.tpWpfmath.Padding = new System.Windows.Forms.Padding(3);
            this.tpWpfmath.Size = new System.Drawing.Size(327, 349);
            this.tpWpfmath.TabIndex = 0;
            this.tpWpfmath.Text = "Math editor";
            this.tpWpfmath.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wb);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(327, 349);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wb
            // 
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.Location = new System.Drawing.Point(3, 3);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(321, 343);
            this.wb.TabIndex = 0;
            // 
            // buttonCopyClipboard
            // 
            this.buttonCopyClipboard.Location = new System.Drawing.Point(11, 316);
            this.buttonCopyClipboard.Name = "buttonCopyClipboard";
            this.buttonCopyClipboard.Size = new System.Drawing.Size(149, 23);
            this.buttonCopyClipboard.TabIndex = 3;
            this.buttonCopyClipboard.Text = "Copy to clipboard";
            this.buttonCopyClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyClipboard.Click += new System.EventHandler(this.buttonCopyClipboard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(335, 422);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Mathink editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpWpfmath.ResumeLayout(false);
            this.tpWpfmath.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOut;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slErr;
        private System.Windows.Forms.ToolStripStatusLabel slRet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSVGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTxtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cpyOutPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProgDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topWindowToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpWpfmath;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonCopyClipboard;
    }
}

