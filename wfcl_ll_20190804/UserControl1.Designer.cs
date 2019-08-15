namespace wfcl_ll_20190804
{
    partial class UserControl1
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_zoom = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox_shrink = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_shrink)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_zoom);
            this.panel1.Controls.Add(this.pictureBox_close);
            this.panel1.Controls.Add(this.pictureBox_shrink);
            this.panel1.Location = new System.Drawing.Point(270, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 30);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_zoom
            // 
            this.pictureBox_zoom.Location = new System.Drawing.Point(56, 3);
            this.pictureBox_zoom.Name = "pictureBox_zoom";
            this.pictureBox_zoom.Size = new System.Drawing.Size(25, 22);
            this.pictureBox_zoom.TabIndex = 1;
            this.pictureBox_zoom.TabStop = false;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Location = new System.Drawing.Point(112, 3);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(25, 22);
            this.pictureBox_close.TabIndex = 2;
            this.pictureBox_close.TabStop = false;
            // 
            // pictureBox_shrink
            // 
            this.pictureBox_shrink.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_shrink.Name = "pictureBox_shrink";
            this.pictureBox_shrink.Size = new System.Drawing.Size(25, 22);
            this.pictureBox_shrink.TabIndex = 3;
            this.pictureBox_shrink.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(413, 257);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_shrink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_zoom;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.PictureBox pictureBox_shrink;
    }
}
