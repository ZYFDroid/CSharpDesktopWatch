﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Watch
{
    public partial class Form1 : Form
    {
        Image thisImage;
        Graphics thisGraphics;

        public class TimeSpot {
            public long timePosition;
            public string comment;
        }

        const string tempFilename = "currentTimer.tmrx";

        private DateTime offset = new DateTime(2019, 1, 1);
        public long SystemClock { get { return (long)(DateTime.Now - offset).TotalMilliseconds; } }
        public List<TimeSpot> timers = new List<TimeSpot>();

        public long getTotalTime()
        {
            long time = 0;
            long lastStartTime = SystemClock;
            for (int i = 0; i < timers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lastStartTime = timers[i].timePosition;
                }
                else
                {
                    time += (timers[i].timePosition - lastStartTime);
                    lastStartTime = SystemClock;
                }
            }
            time += (SystemClock - lastStartTime);
            return time;
        }

        int hour = 0;
        int minute = 0;
        int second = 0;
        int millisecond = 0;

        public void longToTime(long input)
        {
            if (input < 0)
            {
                longToTime(-input);
                millisecond = -millisecond;
                second = -second;
                minute = -minute;
                hour = -hour;
            }
            long time = input;
            millisecond = (int)(time % 1000L);
            time -= millisecond;
            time = time / 1000;
            second = (int)(time % 60L);
            time -= second;
            time = time / 60;
            minute = (int)(time % 60L);
            time -= minute;
            time = time / 60;
            hour = (int)time;


        }
        public void saveTime(string path)
        {
            StringBuilder sbuilder = new StringBuilder();
            for (int i = 0; i < timers.Count; i++)
            {
                TimeSpot timeObj = timers[i];
                sbuilder.Append(timeObj.timePosition);
                if (null!=timeObj.comment && "" != timeObj.comment) {
                    sbuilder.Append("#").Append(timeObj.comment);
                }
                if (i < timers.Count - 1) { sbuilder.Append("\n"); }
            }
            File.WriteAllText(path, sbuilder.ToString());
        }

        char[] separator = { '#'};

        public void loadTime(string path)
        {
            if (File.Exists(path))
            {
                timers.Clear();
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    TimeSpot timeObj = new TimeSpot();
                    string str = lines[i];
                    if (str.Contains("#"))
                    {
                        string[] strs=str.Split(separator,2);
                        timeObj.timePosition = Int64.Parse(strs[0]);
                        timeObj.comment = strs[1];
                    }
                    else
                    {
                        timeObj.timePosition = Int64.Parse(lines[i]);
                    }

                    if (lines[i].Trim() != "")
                    {
                        timers.Add(timeObj);
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.thisImage = new Bitmap(this.Width, this.Height);
            this.thisGraphics = Graphics.FromImage(thisImage);
            this.thisGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
            this.thisGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.thisGraphics.Clear(Color.FromArgb(0x007f7f00));
            if (File.Exists(tempFilename))
            {
                loadTime(tempFilename);
                IsClockMode = false;
            }
        }


        Bitmap clockface = Properties.Resources.clockface;

        Bitmap hand_hour_shadow = Properties.Resources.handhour_shadow;
        Bitmap hand_min_shadow = Properties.Resources.handmin_shadow;
        Bitmap hand_sec_shadow = Properties.Resources.handsec_shadow;

        Bitmap hand_hour = Properties.Resources.handhour;
        Bitmap hand_min = Properties.Resources.handmin;
        Bitmap hand_sec = Properties.Resources.handsec;
        Bitmap hand_millisec = Properties.Resources.millisecond;

        Bitmap btn_note = Properties.Resources.btn_record;

        #region FormEffect

        public void drawRotateImg(Image img, float angle, Graphics g, float centerX, float centerY)
        {
            drawRotateImg(img, angle, g, centerX, centerY, img.Width, img.Height);
        }

        public void drawRotateImg(Image img, float angle, Graphics g, float centerX, float centerY, float imgW, float imgH)
        {
            float width = imgW;
            float height = imgH;
            Matrix mtrx = new Matrix();
            mtrx.RotateAt(angle, new PointF((width / 2), (height / 2)), MatrixOrder.Append);
            //得到旋转后的矩形
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, width, height));
            RectangleF rct = path.GetBounds(mtrx);
            Point Offset = new Point((int)(rct.Width - width) / 2, (int)(rct.Height - height) / 2);
            //构造图像显示区域：让图像的中心与窗口的中心点一致
            RectangleF rect = new RectangleF(-width / 2 + centerX, -height / 2 + centerY, (int)width, (int)height);
            PointF center = new PointF((int)(rect.X + rect.Width / 2), (int)(rect.Y + rect.Height / 2));
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(angle);
            //恢复图像在水平和垂直方向的平移
            g.TranslateTransform(-center.X, -center.Y);
            g.DrawImage(img, rect);
            //重至绘图的所有变换
            g.ResetTransform();
        }


        bool haveHandle = false;
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = false;
            base.OnClosing(e);
            haveHandle = false;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            InitializeStyles();
            base.OnHandleCreated(e);
            haveHandle = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cParms = base.CreateParams;
                cParms.ExStyle |= 0x00080000; // WS_EX_LAYERED
                return cParms;
            }
        }


        private void InitializeStyles()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        public void SetBits(Bitmap bitmap)
        {
            if (!haveHandle) return;

            if (!Bitmap.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Bitmap.IsAlphaPixelFormat(bitmap.PixelFormat))
                throw new ApplicationException("The picture must be 32bit picture with alpha channel.");

            IntPtr oldBits = IntPtr.Zero;
            IntPtr screenDC = Win32.GetDC(IntPtr.Zero);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr memDc = Win32.CreateCompatibleDC(screenDC);

            try
            {
                Win32.Point topLoc = new Win32.Point(Left, Top);
                Win32.Size bitMapSize = new Win32.Size(bitmap.Width, bitmap.Height);
                Win32.BLENDFUNCTION blendFunc = new Win32.BLENDFUNCTION();
                Win32.Point srcLoc = new Win32.Point(0, 0);

                hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                oldBits = Win32.SelectObject(memDc, hBitmap);

                blendFunc.BlendOp = Win32.AC_SRC_OVER;
                blendFunc.SourceConstantAlpha = 255;
                blendFunc.AlphaFormat = Win32.AC_SRC_ALPHA;
                blendFunc.BlendFlags = 0;

                Win32.UpdateLayeredWindow(Handle, screenDC, ref topLoc, ref bitMapSize, memDc, ref srcLoc, 0, ref blendFunc, Win32.ULW_ALPHA);
            }
            finally
            {
                if (hBitmap != IntPtr.Zero)
                {
                    Win32.SelectObject(memDc, oldBits);
                    Win32.DeleteObject(hBitmap);
                }
                Win32.ReleaseDC(IntPtr.Zero, screenDC);
                Win32.DeleteDC(memDc);
            }
        }

        #endregion

        Process me = Process.GetCurrentProcess();

        bool inited = false;

        bool IsClockMode
        {
            get { return mIsClock; }
            set
            {
                button2.Visible = !value;
                button3.Visible = value;
                button4.Visible = !value;
                mIsClock = value;
            }
        }

        RectangleF stringarea;
        StringFormat centerformat;

        bool mIsClock = true;

        bool shouldStopAfterTimeup = false;

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            if (!inited)
            {
                Bitmap tmp;
                tmp = clockface;
                clockface = new Bitmap(clockface, ClientSize);
                tmp.Dispose();
                tmp = hand_hour;
                hand_hour = new Bitmap(hand_hour, clocksize.Size);
                tmp.Dispose();
                tmp = hand_min;
                hand_min = new Bitmap(hand_min, clocksize.Size);
                tmp.Dispose();
                tmp = hand_sec;
                hand_sec = new Bitmap(hand_sec, clocksize.Size);
                tmp.Dispose();
                tmp = hand_hour_shadow;
                hand_hour_shadow = new Bitmap(hand_hour_shadow, clocksize.Width / 3, clocksize.Height / 3);
                tmp.Dispose();
                tmp = hand_min_shadow;
                hand_min_shadow = new Bitmap(hand_min_shadow, clocksize.Width / 3, clocksize.Height / 3);
                tmp.Dispose();
                tmp = hand_sec_shadow;
                hand_sec_shadow = new Bitmap(hand_sec_shadow, clocksize.Width / 3, clocksize.Height / 3);
                tmp.Dispose();
                tmp = hand_millisec;
                hand_millisec = new Bitmap(hand_millisec, millisecOption.Size);
                tmp.Dispose();
                tmp = btn_note;
                btn_note = new Bitmap(btn_note, button4.Size);
                tmp.Dispose();
                stringarea = new RectangleF(rapArea.Left, rapArea.Top, rapArea.Width, rapArea.Height);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                centerformat = sf;
                GC.Collect();
                inited = true;
            }

            this.thisGraphics.Clear(Color.FromArgb(0x007f7f00));
            this.thisGraphics.DrawImage(clockface, 0, 0);

            if (IsClockMode)
            {
                DateTime d = DateTime.Now;
                hour = d.Hour;
                minute = d.Minute;
                second = d.Second;
                millisecond = d.Millisecond;
            }
            else
            {
                longToTime(getTotalTime());
            }
            float mhour = hour + minute / 60f + second / 3600f;
            float mmin = minute + second / 60f + millisecond / 60000f;
            float msec = second + millisecond / 1000f;
            float milsec = millisecond;

            int day = hour / 24;
            bool ampm = hour % 24 >= 12;
            string days = day == 1 ? " DAY\r\n" : " DAYS\r\n";

            drawRotateImg(hand_millisec, milsec * 0.36f, thisGraphics, millisecOption.Left + millisecOption.Width / 2, millisecOption.Top + millisecOption.Height / 2);

            drawRotateImg(hand_hour_shadow, mhour * 30, thisGraphics, centerptr.Left + 4, centerptr.Top + 4, clocksize.Width, clocksize.Height);
            drawRotateImg(hand_min_shadow, mmin * 6, thisGraphics, centerptr.Left + 4, centerptr.Top + 4, clocksize.Width, clocksize.Height);
            drawRotateImg(hand_sec_shadow, msec * 6, thisGraphics, centerptr.Left + 4, centerptr.Top + 4, clocksize.Width, clocksize.Height);


            drawRotateImg(hand_hour, mhour * 30, thisGraphics, centerptr.Left, centerptr.Top, clocksize.Width, clocksize.Height);
            drawRotateImg(hand_min, mmin * 6, thisGraphics, centerptr.Left, centerptr.Top, clocksize.Width, clocksize.Height);
            drawRotateImg(hand_sec, msec * 6, thisGraphics, centerptr.Left, centerptr.Top, clocksize.Width, clocksize.Height);

            if (!IsClockMode && hour >= 12)
            {
                thisGraphics.DrawString(day + days + (ampm ? "PM" : "AM"), SystemFonts.DefaultFont, Brushes.Red, stringarea, centerformat);
            }

            if (!IsClockMode) {
                thisGraphics.DrawImage(btn_note, button4.Left, button4.Top);
            }

            SetBits((Bitmap)this.thisImage);



        }

        int dx = 0, dy = 0;
        bool clickdown = false;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            clickdown = true;
            dx = e.X;
            dy = e.Y;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickdown)
            {
                this.Top += e.Y - dy;
                this.Left += e.X - dx;
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpot timeObj = new TimeSpot();
            timeObj.timePosition = SystemClock;
            timers.Add(timeObj);
            saveTime(tempFilename);
        }

        private void GCTimer_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (getTotalTime() != 0)
                {
                    if (MessageBox.Show("是否覆盖当前的计时？", "打开计时", MessageBoxButtons.YesNo) != DialogResult.Yes) { return; }
                }
                loadTime(openFileDialog1.FileName);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (getTotalTime() == 0)
                {
                    MessageBox.Show("计时尚未开始，因此不能保存计时", "保存计时");
                    return;
                }
                saveTime(saveFileDialog1.FileName);
                MessageBox.Show("保存成功");

            }
        }

        private void 重置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否重置计时？", "是否重置计时", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete(tempFilename);
                timers.Clear();
                toolStripMenuItem3.Enabled = true;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该计时器通过保存每次开始和停止的时间来实现在不启用程序的情况下持续计时，因此计时器启动之后，即使程序关闭、电脑关机，也能继续准确计时，计时过程中请不要修改系统时间。临时计时文件保存在程序目录下的"+tempFilename+"中\r\n可以保存和打开已有的计时器记录，包括已完成计时的以及正在计时的\r\n\r\n怀表版计时器和普通版计时器存档通用", "非易失性计时器帮助");

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("非易失性计时器\r\n版本 " + Application.ProductVersion + " 怀表版\r\nZYFDroid Assistant Technology", "关于非易失性计时器");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (!IsClockMode)
            {
                toolStripMenuItem7.Checked = toolStripMenuItem7.Checked;
            }

            TopMost = toolStripMenuItem5.Checked;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            IsClockMode = true;
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (IsClockMode)
            {
                toolStripMenuItem5.Checked = toolStripMenuItem7.Checked;
            }
            TopMost = toolStripMenuItem7.Checked;
        }

        private void 切换到计时器模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsClockMode = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            renderTimer.Enabled = (WindowState != FormWindowState.Minimized);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clocksize_Click(object sender, EventArgs e)
        {

        }

        SRead speech = new SRead();

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (ReadWorker.IsBusy) { return; }
            ReadWorker.RunWorkerAsync();
        }

        private void ReadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int h = hour;
            int m = minute;
            bool isclock = IsClockMode;
            if (h > 99) { return; }
            if (isclock)
            {
                speech.readTime(h, m);
            }
            else {
                speech.readStopWatch(h, m);
            }
        }

        public bool IsPaused {
            get { return timers.Count % 2 == 0; }
        }

        private void mnuRecordTimeComment_Click(object sender, EventArgs e)
        {
            bool paused = IsPaused;
            bool haveTime = timers.Count > 0;
            if (!haveTime) { MessageBox.Show("尚未开始计时"); return; }

            if (!paused)
            {
                TimeSpot timeObj = new TimeSpot();
                timeObj.timePosition = SystemClock;
                timers.Add(timeObj);
            }
            else {
                TimeSpot timeObj = new TimeSpot();
                timeObj.timePosition = SystemClock;
                timers.Add(timeObj);
                timeObj = new TimeSpot();
                timeObj.timePosition = SystemClock;
                timers.Add(timeObj);
            }


            string msg;
            InputBox ipb = new InputBox();
            if (ipb.GetInput(out msg) == DialogResult.OK) {
                (timers[timers.Count - 1]).comment = msg;
            }
            ipb.Dispose();
            if (!paused) {
                TimeSpot timeObj = new TimeSpot();
                timeObj.timePosition = SystemClock;
                timers.Add(timeObj);
            }
            saveTime(tempFilename);
        }

        private void mnuShowReport_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (timers.Count == 0) { MessageBox.Show("尚未开始计时"); return; }
            sb.Append(">>>计时开始>>>").Append("\r\n");
            long time = 0;
            long lastStartTime = SystemClock;
            for (int i = 0; i < timers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lastStartTime = timers[i].timePosition;
                }
                else
                {
                    time += (timers[i].timePosition - lastStartTime);
                    lastStartTime = SystemClock;
                }
                if (null != timers[i].comment && "" != timers[i].comment) {
                    sb.Append("[").Append(longToTimeStr(time)).Append("] ").Append(timers[i].comment).Append("\r\n");
                }

            }
            time += (SystemClock - lastStartTime);
            if (IsPaused)
            {
                sb.Append("<<<计时结束<<<");
            }
            else {
                sb.Append("[").Append(longToTimeStr(time)).Append("] <<<计时尚未结束<<<");
            }
            FormLongMsg flm = new FormLongMsg();
            flm.textBox1.Text = sb.ToString();
            flm.textBox1.ReadOnly = true;
            Application.DoEvents();
            flm.textBox1.SelectionStart = 0;
            flm.textBox1.SelectionLength = 0;
            flm.ShowDialog();
            flm.Dispose();
        }

        public string longToTimeStr(long input)
        {
            if (input < 0)
            {
                return "-" + longToTimeStr(-input);
            }

            int hour = 0;
            int minute = 0;
            int second = 0;
            int millisecond = 0;
            long time = input;
            millisecond = (int)(time % 1000L);
            time -= millisecond;
            time = time / 1000;
            second = (int)(time % 60L);
            time -= second;
            time = time / 60;
            minute = (int)(time % 60L);
            time -= minute;
            time = time / 60;
            hour = (int)time;
            if (input + 1 % 1000 == 0) { GC.Collect(); }

            return toBitString(hour, 2) + ":" + toBitString(minute, 2) + ":" + toBitString(second, 2) + "." + toBitString(millisecond, 3);

        }

        public string toBitString(int num, int len)
        {
            string s = num.ToString();
            while (s.Length < len)
            {
                s = "0" + s;
            }
            return s;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            new TimePickDialog().ShowDialog();
        }
        
        private void toolStripMenuItem14_MouseEnter(object sender, EventArgs e)
        {
            
        }

        SoundPlayer enterSound = new SoundPlayer(Properties.Resources.enter);
        SoundPlayer clickSound = new SoundPlayer(Properties.Resources.click);

        private void toolStripMenuItem10_MouseEnter(object sender, EventArgs e)
        {
            enterSound.Play();
        }

        private void toolStripMenuItem10_MouseDown(object sender, MouseEventArgs e)
        {
            clickSound.Play();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            clickdown = false;
        }
    }

    #region Win32
    internal class Win32
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Size
        {
            public Int32 cx;
            public Int32 cy;

            public Size(Int32 x, Int32 y)
            {
                cx = x;
                cy = y;
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Point
        {
            public Int32 x;
            public Int32 y;

            public Point(Int32 x, Int32 y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public const byte AC_SRC_OVER = 0;
        public const Int32 ULW_ALPHA = 2;
        public const byte AC_SRC_ALPHA = 1;

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll", ExactSpelling = true)]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObj);

        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern int DeleteDC(IntPtr hDC);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern int DeleteObject(IntPtr hObj);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern int UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, Int32 crKey, ref BLENDFUNCTION pblend, Int32 dwFlags);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr ExtCreateRegion(IntPtr lpXform, uint nCount, IntPtr rgnData);
    }
    #endregion


    public class SRead
    {
        SoundPlayer mplayer = new SoundPlayer();
        public void read(string text) {
            Assembly asm = Assembly.GetExecutingAssembly();
            for (int i = 0; i < text.Length; i++) {
                Stream stream = asm.GetManifestResourceStream("Watch."+text.Substring(i, 1) + ".wav");
                mplayer.Stream = stream;
                mplayer.PlaySync();
                mplayer.Stream = null;
                stream.Close();
            }
        }


        public void readTime(int hour, int minute) {
            string result = "";
            if (minute != 0)
            {
                result = intToChinese(hour) + "点" + intToChinese2(minute) + "分";
            }
            else
            {
                result = intToChinese(hour) + "点整";
            }
            read("当报"+result);
        }
        public void readStopWatch(int hour, int minute) {
            if (hour < 1)
            {
                read("当计" + intToChinese(minute) + "分钟");
            }
            else
            {
                if (minute != 0)
                {
                    read("当计" + intToChinese(hour) + "小时" + intToChinese2(minute) + "分钟");
                }
                else
                {
                    read("当计" + intToChinese(hour) + "小时");
                }
            }
        }


        string[] digits = {"零","一","二","三","四","五","六","七","八","九" };
        public string intToChinese(int i) {
            if (i >= 100 || i < 0) { throw new InvalidEnumArgumentException(); }
            int ge = i % 10;
            int tens = (i - ge) / 10;
            if (tens == 0) {
                return digits[ge];
            }
            string shi = "";
            string ges = "";
            if (tens >= 0) {
                if (tens == 1)
                {
                    shi = "十";
                }
                else {
                    shi = digits[tens] + "十";
                }

                if (ge > 0) {
                    ges = digits[ge];
                }
            }
            return shi + ges;
        }

        public string intToChinese2(int i)
        {
            if (i >= 100 || i < 0) { throw new InvalidEnumArgumentException(); }
            int ge = i % 10;
            int tens = (i - ge) / 10;
            if (tens == 0)
            {
                return "零"+digits[ge];
            }
            string shi = "";
            string ges = "";
            if (tens >= 0)
            {
                if (tens == 1)
                {
                    shi = "十";
                }
                else
                {
                    shi = digits[tens] + "十";
                }

                if (ge > 0)
                {
                    ges = digits[ge];
                }
            }
            return shi + ges;
        }
    }
}

