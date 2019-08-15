using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace wf_blackback_20190803
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //  SetWindowRegion();

            //SetForm();

            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\nomal.png");
            pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\x.png");
            pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\smal.png");
            pictureBox3.BackColor = Color.FromArgb(45,45,48);
            pictureBox4.BackColor = Color.FromArgb(45, 45, 48);
            pictureBox2.BackColor = Color.FromArgb(45, 45, 48);
            pictureBox_close.Image = Image.FromFile(Application.StartupPath + "\\x.png");

            menuStrip1.Renderer = new MenuItemRenderer();

            // label3.Text = "TD";

            attentation();

        }

        //#region 鼠标拖拽
        //// 可拖拽：

        //private Point mPoint = new Point();
        //private void Form1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    mPoint.X = e.X;
        //    mPoint.Y = e.Y;
        //}
        //private void Form1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        Point myPosittion = MousePosition;
        //        myPosittion.Offset(-mPoint.X, -mPoint.Y);
        //        Location = myPosittion;
        //    }
        //}
        //#endregion

        //#region  四周圆角   

        //private void FormLogin_Resize(object sender, EventArgs e)
        //{
        //    SetWindowRegion();
        //}

        //public void SetWindowRegion()
        //{
        //    System.Drawing.Drawing2D.GraphicsPath FormPath;
        //    FormPath = new System.Drawing.Drawing2D.GraphicsPath();
        //    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
        //    FormPath = GetRoundedRectPath(rect, 10);
        //    this.Region = new Region(FormPath);

        //}
        //private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        //{
        //    int diameter = radius;
        //    Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
        //    GraphicsPath path = new GraphicsPath();

        //    // 左上角
        //    path.AddArc(arcRect, 180, 90);

        //    // 右上角
        //    arcRect.X = rect.Right - diameter;
        //    path.AddArc(arcRect, 270, 90);

        //    // 右下角
        //    arcRect.Y = rect.Bottom - diameter;
        //    path.AddArc(arcRect, 0, 90);

        //    // 左下角
        //    arcRect.X = rect.Left;
        //    path.AddArc(arcRect, 90, 90);
        //    path.CloseFigure();//闭合曲线
        //    return path;
        //}
        //#endregion

        //#region 点击任务栏实现最小化

        //[DllImport("user32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto)]
        //public static extern int GetWindowLong(HandleRef hWnd, int nIndex);

        //[DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        //public static extern IntPtr SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong);


        //public void SetForm()
        //{
        //    int WS_SYSMENU = 0x00080000; // 系统菜单
        //    int WS_MINIMIZEBOX = 0x20000; // 最大最小化按钮
        //    int windowLong = (GetWindowLong(new HandleRef(this, this.Handle), -16));
        //    SetWindowLong(new HandleRef(this, this.Handle), -16, windowLong | WS_SYSMENU | WS_MINIMIZEBOX);
        //}

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义，可以从MFC中查看 
        //        CreateParams cp = base.CreateParams;
        //        cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作   
        //        return cp;
        //    }

        //}
        //#endregion



        ////#region 使窗体可以移动的代码
        ////[DllImport("user32.dll")]
        ////public static extern bool ReleaseCapture();
        ////[DllImport("user32.dll")]
        ////public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        ////public const int WM_SYSCOMMAND = 0x0112;
        ////public const int SC_MOVE = 0xF010;
        ////public const int HTCAPTION = 0x0002;


        ////// 在窗体的Mouse_Down事件中调用

        ////private void Form1_MouseDown(object sender, MouseEventArgs e)
        ////{
        ////    //拖动窗体
        ////    this.Cursor = System.Windows.Forms.Cursors.Hand;//改变鼠标样式
        ////    ReleaseCapture();
        ////    SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        ////    this.Cursor = System.Windows.Forms.Cursors.Default;
        ////}
        ////#endregion


        //#region 支持改变窗体大小
        //private const int Guying_HTLEFT = 10;
        //private const int Guying_HTRIGHT = 11;
        //private const int Guying_HTTOP = 12;
        //private const int Guying_HTTOPLEFT = 13;
        //private const int Guying_HTTOPRIGHT = 14;
        //private const int Guying_HTBOTTOM = 15;
        //private const int Guying_HTBOTTOMLEFT = 0x10;
        //private const int Guying_HTBOTTOMRIGHT = 17;
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case 0x0084:
        //            base.WndProc(ref m);
        //            Point vPoint = new Point((int)m.LParam & 0xFFFF, (int)m.LParam >> 16 & 0xFFFF);
        //            vPoint = PointToClient(vPoint);
        //            if (vPoint.X <= 5)
        //                if (vPoint.Y <= 5)
        //                    m.Result = (IntPtr)Guying_HTTOPLEFT;
        //                else if (vPoint.Y >= ClientSize.Height - 5)
        //                    m.Result = (IntPtr)Guying_HTBOTTOMLEFT;
        //                else
        //                    m.Result = (IntPtr)Guying_HTLEFT;
        //            else if (vPoint.X >= ClientSize.Width - 5)
        //                if (vPoint.Y <= 5)
        //                    m.Result = (IntPtr)Guying_HTTOPRIGHT;
        //                else if (vPoint.Y >= ClientSize.Height - 5)
        //                    m.Result = (IntPtr)Guying_HTBOTTOMRIGHT;
        //                else
        //                    m.Result = (IntPtr)Guying_HTRIGHT;
        //            else if (vPoint.Y <= 5)
        //                m.Result = (IntPtr)Guying_HTTOP;
        //            else if (vPoint.Y >= ClientSize.Height - 5)
        //                m.Result = (IntPtr)Guying_HTBOTTOM;
        //            break;
        //        case 0x0201://鼠标左键按下的消息
        //            m.Msg = 0x00A1;//更改消息为非客户区按下鼠标
        //            m.LParam = IntPtr.Zero; //默认值
        //            m.WParam = new IntPtr(2);//鼠标放在标题栏内
        //            base.WndProc(ref m);
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}
        //#endregion


        #region panel控件移动
        private System.Drawing.Point mPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new System.Drawing.Point(Location.X + e.X - mPoint.X, Location.Y + e.Y - mPoint.Y);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new System.Drawing.Point(e.X, e.Y);
        }
        #endregion


        #region  拖动窗体/双击最大化的处理

        [DllImport("user32.dll")]//命名空间System.Runtime.InteropServices;
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_RESTORE = 0xF120;
        public const int SC_SIZE = 0xF000;
        //改变窗体大小，SC_SIZE+下面的值
        public const int LEFT = 0x0001;//光标在窗体左边缘
        public const int RIGHT = 0x0002;//右边缘
        public const int UP = 0x0003;//上边缘
        public const int LEFTUP = 0x0004;//左上角
        public const int RIGHTUP = 0x0005;//右上角
        public const int BOTTOM = 0x0006;//下边缘
        public const int LEFTBOTTOM = 0x0007;//左下角
        public const int RIGHTBOTTOM = 0x0008;//右下角

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks <= 1)
            {
                //拖动窗体
                ReleaseCapture();//释放label1对鼠标的捕捉
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            }
            else if (e.Clicks == 2)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    //还原窗体
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_SYSCOMMAND, SC_RESTORE, 0);
                }
                else if (this.WindowState == FormWindowState.Normal)
                {
                    //最大化窗体
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
                }

            }
        }

        #endregion

        #region  拖动右下角改变窗体大小的处理  效果不好
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks <= 1)
            {
                this.Cursor = Cursors.SizeNWSE;
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_SIZE + RIGHTBOTTOM, 0);//拖动右下角改变窗体大小
            }

   
        }
        #endregion

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(45, 45, 48);
            panel2.BackColor = Color.FromArgb(45, 45, 48);
            pictureBox2.Image = Image.FromFile(Application.StartupPath +"\\zoom.png"); 
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel4_mousedown(object sender, MouseEventArgs e)
        {
            //ToolStripMenuItem.BackColor = Color.FromArgb(45,45,48);
            
        }


        //exit
        private void PictureBox_close_Click(object sender, EventArgs e)
        {
            //(63,63,65)
            Application.Exit();
        }

        private void close_mousemove(object sender, MouseEventArgs e)
        {
            pictureBox_close.Image = Image.FromFile(Application.StartupPath + "\\close_red.png");
        }
        private void close_mouseleave(object sender, EventArgs e)
        {
            pictureBox_close.Image = Image.FromFile(Application.StartupPath + "\\x.png");

        }
        private void attentation() {

            ToolTip ttpSettings = new ToolTip();
            ttpSettings.InitialDelay = 200;
            ttpSettings.AutoPopDelay = 10 * 1000;
            ttpSettings.ReshowDelay = 200;
            ttpSettings.ShowAlways = true;
            ttpSettings.IsBalloon = true;

            string tipOverwrite = "关闭";
            ttpSettings.SetToolTip(pictureBox_close, tipOverwrite); // ckbOverwrite is a checkbox

        }


    }
}
