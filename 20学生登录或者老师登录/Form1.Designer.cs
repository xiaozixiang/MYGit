namespace _20学生登录或者老师登录
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.rdostudent = new System.Windows.Forms.RadioButton();
            this.rdoteacher = new System.Windows.Forms.RadioButton();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(164, 110);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(138, 21);
            this.txtname.TabIndex = 2;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(164, 165);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(138, 21);
            this.txtpwd.TabIndex = 3;
            // 
            // rdostudent
            // 
            this.rdostudent.AutoSize = true;
            this.rdostudent.Location = new System.Drawing.Point(134, 232);
            this.rdostudent.Name = "rdostudent";
            this.rdostudent.Size = new System.Drawing.Size(47, 16);
            this.rdostudent.TabIndex = 4;
            this.rdostudent.TabStop = true;
            this.rdostudent.Text = "学生";
            this.rdostudent.UseVisualStyleBackColor = true;
            // 
            // rdoteacher
            // 
            this.rdoteacher.AutoSize = true;
            this.rdoteacher.Location = new System.Drawing.Point(255, 232);
            this.rdoteacher.Name = "rdoteacher";
            this.rdoteacher.Size = new System.Drawing.Size(47, 16);
            this.rdoteacher.TabIndex = 5;
            this.rdoteacher.TabStop = true;
            this.rdoteacher.Text = "老师";
            this.rdoteacher.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(164, 284);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(115, 44);
            this.btn.TabIndex = 6;
            this.btn.Text = "登录";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 433);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.rdoteacher);
            this.Controls.Add(this.rdostudent);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.RadioButton rdostudent;
        private System.Windows.Forms.RadioButton rdoteacher;
        private System.Windows.Forms.Button btn;
    }
}

