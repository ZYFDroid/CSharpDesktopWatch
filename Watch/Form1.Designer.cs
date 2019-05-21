namespace Watch
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecordTimeComment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GCTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.切换到计时器模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadWorker = new System.ComponentModel.BackgroundWorker();
            this.hideBtnTimer = new System.Windows.Forms.Timer(this.components);
            this.picClockFace = new System.Windows.Forms.Panel();
            this.btnFancyReset = new System.Windows.Forms.Button();
            this.btnFancyMin = new System.Windows.Forms.Button();
            this.btnFancyExit = new System.Windows.Forms.Button();
            this.btnFancyPause = new System.Windows.Forms.Button();
            this.btnFancyToggle = new System.Windows.Forms.Button();
            this.btnFancyReport = new System.Windows.Forms.Button();
            this.btnFancyRecord = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.clocksize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rapArea = new System.Windows.Forms.Label();
            this.millisecOption = new System.Windows.Forms.PictureBox();
            this.centerptr = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.picClockFace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.millisecOption)).BeginInit();
            this.SuspendLayout();
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 1;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.mnuRecordTimeComment,
            this.mnuShowReport,
            this.toolStripSeparator2,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.重置ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.退出ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem6,
            this.toolStripMenuItem3,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 292);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem10.Text = "朗读时间";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            this.toolStripMenuItem10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.toolStripMenuItem10.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // mnuRecordTimeComment
            // 
            this.mnuRecordTimeComment.Name = "mnuRecordTimeComment";
            this.mnuRecordTimeComment.Size = new System.Drawing.Size(160, 22);
            this.mnuRecordTimeComment.Text = "记录信息";
            this.mnuRecordTimeComment.Click += new System.EventHandler(this.mnuRecordTimeComment_Click);
            this.mnuRecordTimeComment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.mnuRecordTimeComment.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // mnuShowReport
            // 
            this.mnuShowReport.Name = "mnuShowReport";
            this.mnuShowReport.Size = new System.Drawing.Size(160, 22);
            this.mnuShowReport.Text = "查看时间报告";
            this.mnuShowReport.Click += new System.EventHandler(this.mnuShowReport_Click);
            this.mnuShowReport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.mnuShowReport.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            this.打开ToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.打开ToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            this.保存ToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.保存ToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // 重置ToolStripMenuItem
            // 
            this.重置ToolStripMenuItem.Name = "重置ToolStripMenuItem";
            this.重置ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.重置ToolStripMenuItem.Text = "重置";
            this.重置ToolStripMenuItem.Click += new System.EventHandler(this.重置ToolStripMenuItem_Click);
            this.重置ToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.重置ToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem5.Text = "总在最前";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            this.toolStripMenuItem5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.toolStripMenuItem5.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem4.Text = "最小化";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            this.toolStripMenuItem4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.toolStripMenuItem4.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            this.退出ToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.退出ToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem6.Text = "切换到钟表模式";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            this.toolStripMenuItem6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.toolStripMenuItem6.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 6);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            this.帮助ToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.帮助ToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            this.关于ToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.关于ToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // GCTimer
            // 
            this.GCTimer.Enabled = true;
            this.GCTimer.Interval = 10000;
            this.GCTimer.Tick += new System.EventHandler(this.GCTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "计时器文件|*.tmr|可扩展计时器文件|*.tmrx";
            this.openFileDialog1.FilterIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "可扩展计时器文件|*.tmrx";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.切换到计时器模式ToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.退出ToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.ShowCheckMargin = true;
            this.contextMenuStrip2.ShowImageMargin = false;
            this.contextMenuStrip2.Size = new System.Drawing.Size(173, 114);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem9.Text = "报时";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            this.toolStripMenuItem9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.toolStripMenuItem9.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // 切换到计时器模式ToolStripMenuItem
            // 
            this.切换到计时器模式ToolStripMenuItem.Name = "切换到计时器模式ToolStripMenuItem";
            this.切换到计时器模式ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.切换到计时器模式ToolStripMenuItem.Text = "切换到计时器模式";
            this.切换到计时器模式ToolStripMenuItem.Click += new System.EventHandler(this.切换到计时器模式ToolStripMenuItem_Click);
            this.切换到计时器模式ToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.切换到计时器模式ToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.CheckOnClick = true;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem7.Text = "总在最前";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            this.toolStripMenuItem7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.toolStripMenuItem7.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem8.Text = "最小化";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            this.toolStripMenuItem8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.toolStripMenuItem8.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            this.退出ToolStripMenuItem1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.退出ToolStripMenuItem1.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // ReadWorker
            // 
            this.ReadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReadWorker_DoWork);
            // 
            // hideBtnTimer
            // 
            this.hideBtnTimer.Tick += new System.EventHandler(this.hideBtnTimer_Tick);
            // 
            // picClockFace
            // 
            this.picClockFace.BackgroundImage = global::Watch.Properties.Resources.clockface;
            this.picClockFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClockFace.Controls.Add(this.btnFancyReset);
            this.picClockFace.Controls.Add(this.btnFancyMin);
            this.picClockFace.Controls.Add(this.btnFancyExit);
            this.picClockFace.Controls.Add(this.btnFancyPause);
            this.picClockFace.Controls.Add(this.btnFancyToggle);
            this.picClockFace.Controls.Add(this.btnFancyReport);
            this.picClockFace.Controls.Add(this.btnFancyRecord);
            this.picClockFace.Controls.Add(this.button2);
            this.picClockFace.Controls.Add(this.button3);
            this.picClockFace.Controls.Add(this.clocksize);
            this.picClockFace.Controls.Add(this.button1);
            this.picClockFace.Controls.Add(this.rapArea);
            this.picClockFace.Controls.Add(this.millisecOption);
            this.picClockFace.Controls.Add(this.centerptr);
            this.picClockFace.Location = new System.Drawing.Point(38, 31);
            this.picClockFace.Name = "picClockFace";
            this.picClockFace.Size = new System.Drawing.Size(391, 513);
            this.picClockFace.TabIndex = 11;
            this.picClockFace.MouseEnter += new System.EventHandler(this.picClockFace_MouseEnter);
            this.picClockFace.MouseHover += new System.EventHandler(this.picClockFace_MouseHover);
            this.picClockFace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picClockFace_MouseMove);
            // 
            // btnFancyReset
            // 
            this.btnFancyReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFancyReset.Location = new System.Drawing.Point(88, 441);
            this.btnFancyReset.Name = "btnFancyReset";
            this.btnFancyReset.Size = new System.Drawing.Size(60, 60);
            this.btnFancyReset.TabIndex = 12;
            this.btnFancyReset.Text = "重置按钮";
            this.btnFancyReset.UseVisualStyleBackColor = true;
            this.btnFancyReset.Visible = false;
            this.btnFancyReset.Click += new System.EventHandler(this.btnFancyReset_Click);
            this.btnFancyReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseDown);
            this.btnFancyReset.MouseEnter += new System.EventHandler(this.btnFancyRecord_MouseEnter);
            this.btnFancyReset.MouseLeave += new System.EventHandler(this.btnFancyRecord_MouseLeave);
            // 
            // btnFancyMin
            // 
            this.btnFancyMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFancyMin.Location = new System.Drawing.Point(318, 345);
            this.btnFancyMin.Name = "btnFancyMin";
            this.btnFancyMin.Size = new System.Drawing.Size(60, 60);
            this.btnFancyMin.TabIndex = 12;
            this.btnFancyMin.Text = "最小化按钮";
            this.btnFancyMin.UseVisualStyleBackColor = true;
            this.btnFancyMin.Click += new System.EventHandler(this.btnFancyMin_Click);
            this.btnFancyMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseDown);
            this.btnFancyMin.MouseEnter += new System.EventHandler(this.btnFancyRecord_MouseEnter);
            this.btnFancyMin.MouseLeave += new System.EventHandler(this.btnFancyRecord_MouseLeave);
            this.btnFancyMin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseUp);
            // 
            // btnFancyExit
            // 
            this.btnFancyExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFancyExit.Location = new System.Drawing.Point(282, 404);
            this.btnFancyExit.Name = "btnFancyExit";
            this.btnFancyExit.Size = new System.Drawing.Size(60, 60);
            this.btnFancyExit.TabIndex = 10;
            this.btnFancyExit.Text = "退出按钮";
            this.btnFancyExit.UseVisualStyleBackColor = true;
            this.btnFancyExit.Click += new System.EventHandler(this.btnFancyExit_Click);
            this.btnFancyExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseDown);
            this.btnFancyExit.MouseEnter += new System.EventHandler(this.btnFancyRecord_MouseEnter);
            this.btnFancyExit.MouseLeave += new System.EventHandler(this.btnFancyRecord_MouseLeave);
            // 
            // btnFancyPause
            // 
            this.btnFancyPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFancyPause.Location = new System.Drawing.Point(156, 453);
            this.btnFancyPause.Name = "btnFancyPause";
            this.btnFancyPause.Size = new System.Drawing.Size(60, 60);
            this.btnFancyPause.TabIndex = 10;
            this.btnFancyPause.Text = "暂停按钮";
            this.btnFancyPause.UseVisualStyleBackColor = true;
            this.btnFancyPause.Visible = false;
            this.btnFancyPause.Click += new System.EventHandler(this.btnFancyPause_Click);
            this.btnFancyPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseDown);
            this.btnFancyPause.MouseEnter += new System.EventHandler(this.btnFancyRecord_MouseEnter);
            this.btnFancyPause.MouseLeave += new System.EventHandler(this.btnFancyRecord_MouseLeave);
            this.btnFancyPause.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseUp);
            // 
            // btnFancyToggle
            // 
            this.btnFancyToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFancyToggle.Location = new System.Drawing.Point(225, 441);
            this.btnFancyToggle.Name = "btnFancyToggle";
            this.btnFancyToggle.Size = new System.Drawing.Size(60, 60);
            this.btnFancyToggle.TabIndex = 10;
            this.btnFancyToggle.Text = "切换按钮";
            this.btnFancyToggle.UseVisualStyleBackColor = true;
            this.btnFancyToggle.Click += new System.EventHandler(this.btnFancyToggle_Click);
            this.btnFancyToggle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseDown);
            this.btnFancyToggle.MouseEnter += new System.EventHandler(this.btnFancyRecord_MouseEnter);
            this.btnFancyToggle.MouseLeave += new System.EventHandler(this.btnFancyRecord_MouseLeave);
            this.btnFancyToggle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseUp);
            // 
            // btnFancyReport
            // 
            this.btnFancyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFancyReport.Location = new System.Drawing.Point(31, 404);
            this.btnFancyReport.Name = "btnFancyReport";
            this.btnFancyReport.Size = new System.Drawing.Size(60, 60);
            this.btnFancyReport.TabIndex = 10;
            this.btnFancyReport.Text = "报时按钮";
            this.btnFancyReport.UseVisualStyleBackColor = true;
            this.btnFancyReport.Click += new System.EventHandler(this.btnFancyReport_Click);
            this.btnFancyReport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseDown);
            this.btnFancyReport.MouseEnter += new System.EventHandler(this.btnFancyRecord_MouseEnter);
            this.btnFancyReport.MouseLeave += new System.EventHandler(this.btnFancyRecord_MouseLeave);
            this.btnFancyReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseUp);
            // 
            // btnFancyRecord
            // 
            this.btnFancyRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFancyRecord.Location = new System.Drawing.Point(-4, 345);
            this.btnFancyRecord.Name = "btnFancyRecord";
            this.btnFancyRecord.Size = new System.Drawing.Size(60, 60);
            this.btnFancyRecord.TabIndex = 9;
            this.btnFancyRecord.Text = "记录按钮";
            this.btnFancyRecord.UseVisualStyleBackColor = true;
            this.btnFancyRecord.Visible = false;
            this.btnFancyRecord.Click += new System.EventHandler(this.btnFancyRecord_Click);
            this.btnFancyRecord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFancyRecord_MouseDown);
            this.btnFancyRecord.MouseEnter += new System.EventHandler(this.btnFancyRecord_MouseEnter);
            this.btnFancyRecord.MouseLeave += new System.EventHandler(this.btnFancyRecord_MouseLeave);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(158, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "计时按钮";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem10_MouseDown);
            this.button2.MouseEnter += new System.EventHandler(this.toolStripMenuItem10_MouseEnter);
            // 
            // button3
            // 
            this.button3.ContextMenuStrip = this.contextMenuStrip2;
            this.button3.Location = new System.Drawing.Point(90, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 192);
            this.button3.TabIndex = 6;
            this.button3.Text = "时钟模式右键菜单";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // clocksize
            // 
            this.clocksize.ContextMenuStrip = this.contextMenuStrip1;
            this.clocksize.Location = new System.Drawing.Point(90, 208);
            this.clocksize.Name = "clocksize";
            this.clocksize.Size = new System.Drawing.Size(192, 192);
            this.clocksize.TabIndex = 1;
            this.clocksize.Text = "尺寸  计时模式右键菜单";
            this.clocksize.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 154);
            this.button1.TabIndex = 2;
            this.button1.Text = "拖动区域";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // rapArea
            // 
            this.rapArea.BackColor = System.Drawing.Color.Transparent;
            this.rapArea.ForeColor = System.Drawing.Color.Red;
            this.rapArea.Location = new System.Drawing.Point(137, 268);
            this.rapArea.Name = "rapArea";
            this.rapArea.Size = new System.Drawing.Size(100, 33);
            this.rapArea.TabIndex = 7;
            this.rapArea.Text = "46 DAYS\r\nAM";
            this.rapArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // millisecOption
            // 
            this.millisecOption.BackColor = System.Drawing.Color.Transparent;
            this.millisecOption.Location = new System.Drawing.Point(170, 232);
            this.millisecOption.Name = "millisecOption";
            this.millisecOption.Size = new System.Drawing.Size(35, 35);
            this.millisecOption.TabIndex = 8;
            this.millisecOption.TabStop = false;
            // 
            // centerptr
            // 
            this.centerptr.AutoSize = true;
            this.centerptr.Location = new System.Drawing.Point(186, 304);
            this.centerptr.Name = "centerptr";
            this.centerptr.Size = new System.Drawing.Size(53, 12);
            this.centerptr.TabIndex = 0;
            this.centerptr.Text = "轴心坐标";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 576);
            this.ControlBox = false;
            this.Controls.Add(this.picClockFace);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "怀表";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.picClockFace.ResumeLayout(false);
            this.picClockFace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.millisecOption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.Label centerptr;
        private System.Windows.Forms.Button clocksize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer GCTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 切换到计时器模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.Label rapArea;
        private System.Windows.Forms.PictureBox millisecOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.ComponentModel.BackgroundWorker ReadWorker;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem mnuRecordTimeComment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuShowReport;
        private System.Windows.Forms.Button btnFancyRecord;
        private System.Windows.Forms.Panel picClockFace;
        private System.Windows.Forms.Timer hideBtnTimer;
        private System.Windows.Forms.Button btnFancyToggle;
        private System.Windows.Forms.Button btnFancyReport;
        private System.Windows.Forms.Button btnFancyExit;
        private System.Windows.Forms.Button btnFancyPause;
        private System.Windows.Forms.Button btnFancyMin;
        private System.Windows.Forms.Button btnFancyReset;
    }
}

