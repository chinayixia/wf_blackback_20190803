using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace wf_usercontrol_close_20190810
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            menubarToolTip();
        }

        #region  menubar set
        //menubarToolTip grow/shrink/minimize/close prompt
        private void menubarToolTip()
        {
            ToolTip tooltipclose = new ToolTip();
            tooltipclose.InitialDelay = 200;
            tooltipclose.AutoPopDelay = 10 * 1000;
            tooltipclose.ReshowDelay = 200;
            tooltipclose.ShowAlways = true;
            tooltipclose.IsBalloon = false;

            string tipOverwrite_close = "关闭";
            string tipOverwrite_minimize = "最小化";
            string tipOverwrite_grow = "最大化";
            string tipOverwrite_shrink = "向下还原";
            tooltipclose.SetToolTip(userControl_minimize, tipOverwrite_minimize);
            tooltipclose.SetToolTip(userControl_close1, tipOverwrite_close);
            tooltipclose.SetToolTip(userControl_shrink, tipOverwrite_shrink);
            tooltipclose.SetToolTip(userControl_grow, tipOverwrite_grow);
        }
        private void userControl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            // this.Hide();
        }
        private void userControl_grow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                //还原窗体
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_RESTORE, 0);
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                //最大化窗体
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
                userControl_grow.Visible = false;
                userControl_shrink.Visible = true;

            }
        }
        private void userControl_shrink_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                //还原窗体
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_RESTORE, 0);
                this.WindowState = FormWindowState.Normal;
                userControl_shrink.Visible = false;
                userControl_grow.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                //最大化窗体
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
            }
        }
        private void userControl_close1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //mouse move menubar
        [DllImport("user32.dll")]//namespace: System.Runtime.InteropServices;
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
        //change form size,SC_SIZE+bellow valnue
        public const int LEFT = 0x0001;//cursor on form left
        public const int RIGHT = 0x0002;//right
        public const int UP = 0x0003;//upper
        public const int LEFTUP = 0x0004;//left upper
        public const int RIGHTUP = 0x0005;//right upper
        public const int BOTTOM = 0x0006;//bottom
        public const int LEFTBOTTOM = 0x0007;//left bottom
        public const int RIGHTBOTTOM = 0x0008;//right bottom
        private void Panel_menubar_MouseDown(object sender, MouseEventArgs e)
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
                    this.WindowState = FormWindowState.Normal;
                }
                else if (this.WindowState == FormWindowState.Normal)
                {
                    //最大化窗体
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
                }
            }
        }

        // click taskbar minimize
        [DllImport("user32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto)]
        public static extern int GetWindowLong(HandleRef hWnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong);

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义，可以从MFC中查看 
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作   
                return cp;
            }
        }

        // change size by click edge  
        private const int LFORM_HTLEFT = 10;
        private const int LFORM_HTRIGHT = 11;
        private const int LFORM_HTTOP = 12;
        private const int LFORM_HTTOPLEFT = 13;
        private const int LFORM_HTTOPRIGHT = 14;
        private const int LFORM_HTBOTTOM = 15;
        private const int LFORM_HTBOTTOMLEFT = 0x10;
        private const int LFORM_HTBOTTOMRIGHT = 17;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF, (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)LFORM_HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)LFORM_HTBOTTOMLEFT;
                        else
                            m.Result = (IntPtr)LFORM_HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)LFORM_HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)LFORM_HTBOTTOMRIGHT;
                        else
                            m.Result = (IntPtr)LFORM_HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)LFORM_HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)LFORM_HTBOTTOM;
                    break;
                case 0x0201://鼠标左键按下的消息
                    m.Msg = 0x00A1;//更改消息为非客户区按下鼠标
                    m.LParam = IntPtr.Zero; //默认值
                    m.WParam = new IntPtr(2);//鼠标放在标题栏内
                    base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }




        #endregion


    }
}
