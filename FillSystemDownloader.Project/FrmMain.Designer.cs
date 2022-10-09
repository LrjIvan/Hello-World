
namespace FillSystemDownloader.Project
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowe = new System.Windows.Forms.Button();
            this.flpCkbs = new System.Windows.Forms.FlowLayoutPanel();
            this.ckbNewFillServiceInstaller = new System.Windows.Forms.CheckBox();
            this.ckbOldFillServiceInstaller = new System.Windows.Forms.CheckBox();
            this.ckbSyncServiceInstaller = new System.Windows.Forms.CheckBox();
            this.ckbFillManagerClientInstaller = new System.Windows.Forms.CheckBox();
            this.ckbFillSystemDBFile = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtDownloadPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.ckbCheckAll = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flpCkbs.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "充装系统资料下载器";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowe);
            this.groupBox1.Controls.Add(this.flpCkbs);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.txtDownloadPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDownload);
            this.groupBox1.Controls.Add(this.ckbCheckAll);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(628, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "充装系统资料";
            // 
            // btnBrowe
            // 
            this.btnBrowe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowe.Location = new System.Drawing.Point(428, 194);
            this.btnBrowe.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowe.Name = "btnBrowe";
            this.btnBrowe.Size = new System.Drawing.Size(58, 27);
            this.btnBrowe.TabIndex = 7;
            this.btnBrowe.TabStop = false;
            this.btnBrowe.Text = "浏览";
            this.btnBrowe.UseVisualStyleBackColor = true;
            this.btnBrowe.Click += new System.EventHandler(this.btnBrowe_Click);
            // 
            // flpCkbs
            // 
            this.flpCkbs.Controls.Add(this.ckbNewFillServiceInstaller);
            this.flpCkbs.Controls.Add(this.ckbOldFillServiceInstaller);
            this.flpCkbs.Controls.Add(this.ckbSyncServiceInstaller);
            this.flpCkbs.Controls.Add(this.ckbFillManagerClientInstaller);
            this.flpCkbs.Controls.Add(this.ckbFillSystemDBFile);
            this.flpCkbs.Controls.Add(this.checkBox1);
            this.flpCkbs.Controls.Add(this.checkBox2);
            this.flpCkbs.Controls.Add(this.checkBox3);
            this.flpCkbs.Controls.Add(this.checkBox4);
            this.flpCkbs.Controls.Add(this.checkBox5);
            this.flpCkbs.Controls.Add(this.checkBox6);
            this.flpCkbs.Controls.Add(this.checkBox7);
            this.flpCkbs.Controls.Add(this.checkBox8);
            this.flpCkbs.Controls.Add(this.checkBox9);
            this.flpCkbs.Controls.Add(this.checkBox10);
            this.flpCkbs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCkbs.Location = new System.Drawing.Point(26, 47);
            this.flpCkbs.Margin = new System.Windows.Forms.Padding(2);
            this.flpCkbs.Name = "flpCkbs";
            this.flpCkbs.Size = new System.Drawing.Size(592, 142);
            this.flpCkbs.TabIndex = 6;
            // 
            // ckbNewFillServiceInstaller
            // 
            this.ckbNewFillServiceInstaller.AutoSize = true;
            this.ckbNewFillServiceInstaller.Location = new System.Drawing.Point(2, 2);
            this.ckbNewFillServiceInstaller.Margin = new System.Windows.Forms.Padding(2);
            this.ckbNewFillServiceInstaller.Name = "ckbNewFillServiceInstaller";
            this.ckbNewFillServiceInstaller.Size = new System.Drawing.Size(178, 24);
            this.ckbNewFillServiceInstaller.TabIndex = 0;
            this.ckbNewFillServiceInstaller.Text = "新协议充装服务安装包";
            this.ckbNewFillServiceInstaller.UseVisualStyleBackColor = true;
            this.ckbNewFillServiceInstaller.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // ckbOldFillServiceInstaller
            // 
            this.ckbOldFillServiceInstaller.AutoSize = true;
            this.ckbOldFillServiceInstaller.Location = new System.Drawing.Point(2, 30);
            this.ckbOldFillServiceInstaller.Margin = new System.Windows.Forms.Padding(2);
            this.ckbOldFillServiceInstaller.Name = "ckbOldFillServiceInstaller";
            this.ckbOldFillServiceInstaller.Size = new System.Drawing.Size(178, 24);
            this.ckbOldFillServiceInstaller.TabIndex = 0;
            this.ckbOldFillServiceInstaller.Text = "旧协议充装服务安装包";
            this.ckbOldFillServiceInstaller.UseVisualStyleBackColor = true;
            this.ckbOldFillServiceInstaller.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // ckbSyncServiceInstaller
            // 
            this.ckbSyncServiceInstaller.AutoSize = true;
            this.ckbSyncServiceInstaller.Location = new System.Drawing.Point(2, 58);
            this.ckbSyncServiceInstaller.Margin = new System.Windows.Forms.Padding(2);
            this.ckbSyncServiceInstaller.Name = "ckbSyncServiceInstaller";
            this.ckbSyncServiceInstaller.Size = new System.Drawing.Size(133, 24);
            this.ckbSyncServiceInstaller.TabIndex = 0;
            this.ckbSyncServiceInstaller.Text = "同步服务安装包";
            this.ckbSyncServiceInstaller.UseVisualStyleBackColor = true;
            this.ckbSyncServiceInstaller.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // ckbFillManagerClientInstaller
            // 
            this.ckbFillManagerClientInstaller.AutoSize = true;
            this.ckbFillManagerClientInstaller.Location = new System.Drawing.Point(2, 86);
            this.ckbFillManagerClientInstaller.Margin = new System.Windows.Forms.Padding(2);
            this.ckbFillManagerClientInstaller.Name = "ckbFillManagerClientInstaller";
            this.ckbFillManagerClientInstaller.Size = new System.Drawing.Size(163, 24);
            this.ckbFillManagerClientInstaller.TabIndex = 0;
            this.ckbFillManagerClientInstaller.Text = "充装管理界面安装包";
            this.ckbFillManagerClientInstaller.UseVisualStyleBackColor = true;
            this.ckbFillManagerClientInstaller.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // ckbFillSystemDBFile
            // 
            this.ckbFillSystemDBFile.AutoSize = true;
            this.ckbFillSystemDBFile.Location = new System.Drawing.Point(2, 114);
            this.ckbFillSystemDBFile.Margin = new System.Windows.Forms.Padding(2);
            this.ckbFillSystemDBFile.Name = "ckbFillSystemDBFile";
            this.ckbFillSystemDBFile.Size = new System.Drawing.Size(163, 24);
            this.ckbFillSystemDBFile.TabIndex = 0;
            this.ckbFillSystemDBFile.Text = "充装系统数据库文件";
            this.ckbFillSystemDBFile.UseVisualStyleBackColor = true;
            this.ckbFillSystemDBFile.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(184, 2);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "MSSQL 2008 R2 32bit";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(184, 30);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(186, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "MSSQL 2008 R2 64bit";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(184, 58);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(155, 24);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "otp_win32_21.0.1";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(184, 86);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(155, 24);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "otp_win64_21.0.1";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(184, 114);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(197, 24);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "rabbitmq-server-3.7.10";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(385, 2);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(185, 24);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = ".NET Framework 4.5.1";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(385, 30);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(185, 24);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = ".NET Framework 4.7.2";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(385, 58);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(178, 24);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "串口调试助手（丁丁）";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(385, 86);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(148, 24);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "向日葵远程安装包";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(385, 114);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(208, 24);
            this.checkBox10.TabIndex = 10;
            this.checkBox10.Text = "消息队列安装失败解决方案";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(490, 194);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(58, 27);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtDownloadPath
            // 
            this.txtDownloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDownloadPath.Location = new System.Drawing.Point(85, 194);
            this.txtDownloadPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtDownloadPath.Name = "txtDownloadPath";
            this.txtDownloadPath.Size = new System.Drawing.Size(334, 27);
            this.txtDownloadPath.TabIndex = 4;
            this.txtDownloadPath.Text = "D:\\未来信息充装系统资料";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "下载目录：";
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(553, 194);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(66, 27);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "下载";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // ckbCheckAll
            // 
            this.ckbCheckAll.AutoSize = true;
            this.ckbCheckAll.Location = new System.Drawing.Point(9, 24);
            this.ckbCheckAll.Margin = new System.Windows.Forms.Padding(2);
            this.ckbCheckAll.Name = "ckbCheckAll";
            this.ckbCheckAll.Size = new System.Drawing.Size(58, 24);
            this.ckbCheckAll.TabIndex = 0;
            this.ckbCheckAll.Text = "全选";
            this.ckbCheckAll.UseVisualStyleBackColor = true;
            this.ckbCheckAll.CheckedChanged += new System.EventHandler(this.ckbCheckAll_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(628, 28);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(600, 22);
            this.tsProgressBar.Step = 1;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 277);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(628, 175);
            this.txtLog.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(493, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 480);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "下载器";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flpCkbs.ResumeLayout(false);
            this.flpCkbs.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtDownloadPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.CheckBox ckbFillSystemDBFile;
        private System.Windows.Forms.CheckBox ckbFillManagerClientInstaller;
        private System.Windows.Forms.CheckBox ckbSyncServiceInstaller;
        private System.Windows.Forms.CheckBox ckbOldFillServiceInstaller;
        private System.Windows.Forms.CheckBox ckbCheckAll;
        private System.Windows.Forms.CheckBox ckbNewFillServiceInstaller;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.FlowLayoutPanel flpCkbs;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Button btnBrowe;
        private System.Windows.Forms.Button button1;
    }
}

