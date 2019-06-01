namespace _21MDi窗体
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.创建新窗体ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.横向排列ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.纵向排列ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建新窗体ToolStripMenuItem1,
            this.横向排列ToolStripMenuItem1,
            this.纵向排列ToolStripMenuItem1});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(420, 25);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // 创建新窗体ToolStripMenuItem1
            // 
            this.创建新窗体ToolStripMenuItem1.Name = "创建新窗体ToolStripMenuItem1";
            this.创建新窗体ToolStripMenuItem1.Size = new System.Drawing.Size(80, 21);
            this.创建新窗体ToolStripMenuItem1.Text = "创建新窗体";
            this.创建新窗体ToolStripMenuItem1.Click += new System.EventHandler(this.创建新窗体ToolStripMenuItem1_Click);
            // 
            // 横向排列ToolStripMenuItem1
            // 
            this.横向排列ToolStripMenuItem1.Name = "横向排列ToolStripMenuItem1";
            this.横向排列ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.横向排列ToolStripMenuItem1.Text = "横向排列";
            this.横向排列ToolStripMenuItem1.Click += new System.EventHandler(this.横向排列ToolStripMenuItem1_Click);
            // 
            // 纵向排列ToolStripMenuItem1
            // 
            this.纵向排列ToolStripMenuItem1.Name = "纵向排列ToolStripMenuItem1";
            this.纵向排列ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.纵向排列ToolStripMenuItem1.Text = "纵向排列";
            this.纵向排列ToolStripMenuItem1.Click += new System.EventHandler(this.纵向排列ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 422);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 创建新窗体ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 横向排列ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 纵向排列ToolStripMenuItem1;
    }
}

