namespace wf_userdll_20190814
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
            this.panel_close = new System.Windows.Forms.Panel();
            this.panel_grow = new System.Windows.Forms.Panel();
            this.panel_minimize = new System.Windows.Forms.Panel();
            this.panel_menubar = new System.Windows.Forms.Panel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_shrink = new System.Windows.Forms.Panel();
            this.panel_menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_close
            // 
            this.panel_close.Location = new System.Drawing.Point(755, 0);
            this.panel_close.Name = "panel_close";
            this.panel_close.Size = new System.Drawing.Size(45, 30);
            this.panel_close.TabIndex = 0;
            this.panel_close.Click += new System.EventHandler(this.panel_close_Click);
            // 
            // panel_grow
            // 
            this.panel_grow.Location = new System.Drawing.Point(710, 0);
            this.panel_grow.Name = "panel_grow";
            this.panel_grow.Size = new System.Drawing.Size(45, 30);
            this.panel_grow.TabIndex = 1;
            this.panel_grow.Click += new System.EventHandler(this.panel_grow_Click);
            // 
            // panel_minimize
            // 
            this.panel_minimize.ForeColor = System.Drawing.Color.Transparent;
            this.panel_minimize.Location = new System.Drawing.Point(665, 0);
            this.panel_minimize.Name = "panel_minimize";
            this.panel_minimize.Size = new System.Drawing.Size(45, 30);
            this.panel_minimize.TabIndex = 1;
            this.panel_minimize.Click += new System.EventHandler(this.Panel_minimize_Click);
            // 
            // panel_menubar
            // 
            this.panel_menubar.BackColor = System.Drawing.Color.Transparent;
            this.panel_menubar.Controls.Add(this.panel_minimize);
            this.panel_menubar.Controls.Add(this.panel_grow);
            this.panel_menubar.Controls.Add(this.panel_close);
            this.panel_menubar.Location = new System.Drawing.Point(0, 0);
            this.panel_menubar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menubar.Name = "panel_menubar";
            this.panel_menubar.Size = new System.Drawing.Size(800, 30);
            this.panel_menubar.TabIndex = 2;
            this.panel_menubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_menubar_MouseDown);
            // 
            // panel_shrink
            // 
            this.panel_shrink.Location = new System.Drawing.Point(710, 71);
            this.panel_shrink.Name = "panel_shrink";
            this.panel_shrink.Size = new System.Drawing.Size(45, 30);
            this.panel_shrink.TabIndex = 2;
            this.panel_shrink.Click += new System.EventHandler(this.panel_shrink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wf_userdll_20190814.Properties.Resources.backimage454548;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_shrink);
            this.Controls.Add(this.panel_menubar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_menubar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_close;
        private System.Windows.Forms.Panel panel_grow;
        private System.Windows.Forms.Panel panel_minimize;
        private System.Windows.Forms.Panel panel_menubar;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Panel panel_shrink;
    }
}

