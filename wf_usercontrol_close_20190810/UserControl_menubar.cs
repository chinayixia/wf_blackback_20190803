using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wf_usercontrol_close_20190810
{
    public partial class UserControl_menubar : UserControl
    {

        public enum CheckStyle
        {
            style1 = 0,      //black item close
            style2 = 1,     //black item grow 
            style3 = 2,     //black item shrink
            style4 = 3,     //black item minimize
            style5 = 4,
            style6 = 5
        };

        public UserControl_menubar()
        {
            InitializeComponent();

            //设置Style支持透明背景色并且双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;

            this.Cursor = Cursors.Arrow;// Cursors.Hand;
            this.Size = new Size(45,30);//Size(25, 22);

        }


        bool isCheck = true;

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool Checked
        {
            set { isCheck = value; this.Invalidate(); }
            get { return isCheck; }
        }

        CheckStyle checkStyle = CheckStyle.style1;

        /// <summary>
        /// 样式
        /// </summary>
        public CheckStyle CheckStyleX
        {
            set { checkStyle = value; this.Invalidate(); }
            get { return checkStyle; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bitMapOn = null;
            Bitmap bitMapOff = null;

            if (checkStyle == CheckStyle.style1)
            {
                bitMapOn = global::wf_usercontrol_close_20190810.Properties.Resources.close4530_454548;
                bitMapOff = global::wf_usercontrol_close_20190810.Properties.Resources.close4530_red;
            }
            else if (checkStyle == CheckStyle.style2)
            {
                bitMapOn = global::wf_usercontrol_close_20190810.Properties.Resources.grow4530_454548;
                bitMapOff = global::wf_usercontrol_close_20190810.Properties.Resources.grow4530_636365;
            }
            else if (checkStyle == CheckStyle.style3)
            {
                bitMapOn = global::wf_usercontrol_close_20190810.Properties.Resources.shrink4530_454548;
                bitMapOff = global::wf_usercontrol_close_20190810.Properties.Resources.shrink4530_636365;
            }
            else if (checkStyle == CheckStyle.style4)
            {
                bitMapOn = global::wf_usercontrol_close_20190810.Properties.Resources.minimize4530_454548;
                bitMapOff = global::wf_usercontrol_close_20190810.Properties.Resources.minimize4530_636365;
            }
            //else if (checkStyle == CheckStyle.style5)
            //{
            //    bitMapOn = global::myButtonCheckTest.Properties.Resources.btncheckon5;
            //    bitMapOff = global::myButtonCheckTest.Properties.Resources.btncheckoff5;
            //}
            //else if (checkStyle == CheckStyle.style6)
            //{
            //    bitMapOn = global::myButtonCheckTest.Properties.Resources.btncheckon6;
            //    bitMapOff = global::myButtonCheckTest.Properties.Resources.btncheckoff6;
            //}

            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(0, 0, this.Size.Width, this.Size.Height);

            if (isCheck)
            {
                g.DrawImage(bitMapOn, rec);
            }
            else
            {
                g.DrawImage(bitMapOff, rec);
            }
        }

    
        private void UserControl_close_mouseleave(object sender, EventArgs e)
        {
            isCheck = true;
            this.Invalidate();
        }
        private void UserControl_close_mouseenter(object sender, EventArgs e)
        {
            isCheck = !isCheck;
            this.Invalidate();       
        }
    }
}
