namespace _18demo
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
            this.btnlove = new System.Windows.Forms.Button();
            this.btnunlove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlove
            // 
            this.btnlove.Location = new System.Drawing.Point(102, 137);
            this.btnlove.Name = "btnlove";
            this.btnlove.Size = new System.Drawing.Size(118, 32);
            this.btnlove.TabIndex = 0;
            this.btnlove.Text = "爱";
            this.btnlove.UseVisualStyleBackColor = true;
            this.btnlove.Click += new System.EventHandler(this.btnlove_Click);
            // 
            // btnunlove
            // 
            this.btnunlove.Location = new System.Drawing.Point(273, 136);
            this.btnunlove.Name = "btnunlove";
            this.btnunlove.Size = new System.Drawing.Size(107, 33);
            this.btnunlove.TabIndex = 1;
            this.btnunlove.Text = "不爱";
            this.btnunlove.UseVisualStyleBackColor = true;
            this.btnunlove.MouseEnter += new System.EventHandler(this.btnunlove_MouseEnter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(223, 63);
            this.textBox1.TabIndex = 2;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnunlove);
            this.Controls.Add(this.btnlove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlove;
        private System.Windows.Forms.Button btnunlove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

