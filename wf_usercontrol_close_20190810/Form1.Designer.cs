namespace wf_usercontrol_close_20190810
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_menubar = new System.Windows.Forms.Panel();
            this.userControl_shrink = new wf_usercontrol_close_20190810.UserControl_menubar();
            this.userControl_minimize = new wf_usercontrol_close_20190810.UserControl_menubar();
            this.userControl_grow = new wf_usercontrol_close_20190810.UserControl_menubar();
            this.userControl_close1 = new wf_usercontrol_close_20190810.UserControl_menubar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_menubar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menubar
            // 
            this.panel_menubar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_menubar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_menubar.BackColor = System.Drawing.Color.Transparent;
            this.panel_menubar.Controls.Add(this.userControl_shrink);
            this.panel_menubar.Controls.Add(this.userControl_minimize);
            this.panel_menubar.Controls.Add(this.userControl_grow);
            this.panel_menubar.Controls.Add(this.userControl_close1);
            this.panel_menubar.Controls.Add(this.flowLayoutPanel1);
            this.panel_menubar.Controls.Add(this.panel5);
            this.panel_menubar.Location = new System.Drawing.Point(0, 0);
            this.panel_menubar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menubar.Name = "panel_menubar";
            this.panel_menubar.Size = new System.Drawing.Size(800, 30);
            this.panel_menubar.TabIndex = 9;
            this.panel_menubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_menubar_MouseDown);
            // 
            // userControl_shrink
            // 
            this.userControl_shrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_shrink.AutoScroll = true;
            this.userControl_shrink.BackColor = System.Drawing.Color.Transparent;
            this.userControl_shrink.Checked = true;
            this.userControl_shrink.CheckStyleX = wf_usercontrol_close_20190810.UserControl_menubar.CheckStyle.style3;
            this.userControl_shrink.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userControl_shrink.Location = new System.Drawing.Point(710, 0);
            this.userControl_shrink.Name = "userControl_shrink";
            this.userControl_shrink.Size = new System.Drawing.Size(45, 30);
            this.userControl_shrink.TabIndex = 10;
            this.userControl_shrink.Visible = false;
            this.userControl_shrink.Click += new System.EventHandler(this.userControl_shrink_Click);
            // 
            // userControl_minimize
            // 
            this.userControl_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_minimize.AutoScroll = true;
            this.userControl_minimize.BackColor = System.Drawing.Color.Transparent;
            this.userControl_minimize.Checked = true;
            this.userControl_minimize.CheckStyleX = wf_usercontrol_close_20190810.UserControl_menubar.CheckStyle.style4;
            this.userControl_minimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userControl_minimize.Location = new System.Drawing.Point(665, 0);
            this.userControl_minimize.Name = "userControl_minimize";
            this.userControl_minimize.Size = new System.Drawing.Size(45, 30);
            this.userControl_minimize.TabIndex = 11;
            this.userControl_minimize.Click += new System.EventHandler(this.userControl_minimize_Click);
            // 
            // userControl_grow
            // 
            this.userControl_grow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_grow.BackColor = System.Drawing.Color.Transparent;
            this.userControl_grow.Checked = true;
            this.userControl_grow.CheckStyleX = wf_usercontrol_close_20190810.UserControl_menubar.CheckStyle.style2;
            this.userControl_grow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userControl_grow.Location = new System.Drawing.Point(710, 0);
            this.userControl_grow.Name = "userControl_grow";
            this.userControl_grow.Size = new System.Drawing.Size(45, 30);
            this.userControl_grow.TabIndex = 10;
            this.userControl_grow.Click += new System.EventHandler(this.userControl_grow_Click);
            // 
            // userControl_close1
            // 
            this.userControl_close1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_close1.BackColor = System.Drawing.Color.Transparent;
            this.userControl_close1.Checked = true;
            this.userControl_close1.CheckStyleX = wf_usercontrol_close_20190810.UserControl_menubar.CheckStyle.style1;
            this.userControl_close1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userControl_close1.Location = new System.Drawing.Point(755, 0);
            this.userControl_close1.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_close1.Name = "userControl_close1";
            this.userControl_close1.Size = new System.Drawing.Size(45, 30);
            this.userControl_close1.TabIndex = 9;
            this.userControl_close1.Click += new System.EventHandler(this.userControl_close1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(69, 27);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "TD";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoScroll = true;
            this.panel5.AutoSize = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(851, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 0);
            this.panel5.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wf_usercontrol_close_20190810.Properties.Resources.backimage454548;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_menubar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_menubar.ResumeLayout(false);
            this.panel_menubar.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel_menubar;
        private UserControl_menubar userControl_close1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private UserControl_menubar userControl_grow;
        private UserControl_menubar userControl_minimize;
        private UserControl_menubar userControl_shrink;
    }
}

