namespace _40ADO增删改查
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.lblsocre = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblcname = new System.Windows.Forms.Label();
            this.txtcno = new System.Windows.Forms.TextBox();
            this.lblcno = new System.Windows.Forms.Label();
            this.dgvdate = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txteditscore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txteditname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbleditcno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtscore);
            this.groupBox1.Controls.Add(this.lblsocre);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblcname);
            this.groupBox1.Controls.Add(this.txtcno);
            this.groupBox1.Controls.Add(this.lblcno);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "增加数据";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "插入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(447, 29);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(100, 21);
            this.txtscore.TabIndex = 5;
            // 
            // lblsocre
            // 
            this.lblsocre.AutoSize = true;
            this.lblsocre.Location = new System.Drawing.Point(339, 29);
            this.lblsocre.Name = "lblsocre";
            this.lblsocre.Size = new System.Drawing.Size(29, 12);
            this.lblsocre.TabIndex = 4;
            this.lblsocre.Text = "成绩";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(135, 73);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 3;
            // 
            // lblcname
            // 
            this.lblcname.AutoSize = true;
            this.lblcname.Location = new System.Drawing.Point(19, 76);
            this.lblcname.Name = "lblcname";
            this.lblcname.Size = new System.Drawing.Size(29, 12);
            this.lblcname.TabIndex = 2;
            this.lblcname.Text = "专业";
            // 
            // txtcno
            // 
            this.txtcno.Location = new System.Drawing.Point(135, 21);
            this.txtcno.Name = "txtcno";
            this.txtcno.Size = new System.Drawing.Size(100, 21);
            this.txtcno.TabIndex = 1;
            // 
            // lblcno
            // 
            this.lblcno.AutoSize = true;
            this.lblcno.Location = new System.Drawing.Point(19, 21);
            this.lblcno.Name = "lblcno";
            this.lblcno.Size = new System.Drawing.Size(29, 12);
            this.lblcno.TabIndex = 0;
            this.lblcno.Text = "编号";
            // 
            // dgvdate
            // 
            this.dgvdate.AllowUserToAddRows = false;
            this.dgvdate.AllowUserToDeleteRows = false;
            this.dgvdate.AllowUserToResizeColumns = false;
            this.dgvdate.AllowUserToResizeRows = false;
            this.dgvdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdate.Location = new System.Drawing.Point(13, 149);
            this.dgvdate.MultiSelect = false;
            this.dgvdate.Name = "dgvdate";
            this.dgvdate.ReadOnly = true;
            this.dgvdate.RowTemplate.Height = 23;
            this.dgvdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdate.Size = new System.Drawing.Size(618, 142);
            this.dgvdate.TabIndex = 1;
            this.dgvdate.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdate_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txteditscore);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txteditname);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbleditcno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑数据";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txteditscore
            // 
            this.txteditscore.Location = new System.Drawing.Point(341, 29);
            this.txteditscore.Name = "txteditscore";
            this.txteditscore.Size = new System.Drawing.Size(100, 21);
            this.txteditscore.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "成绩";
            // 
            // txteditname
            // 
            this.txteditname.Location = new System.Drawing.Point(109, 77);
            this.txteditname.Name = "txteditname";
            this.txteditname.Size = new System.Drawing.Size(100, 21);
            this.txteditname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "专业";
            // 
            // lbleditcno
            // 
            this.lbleditcno.AutoSize = true;
            this.lbleditcno.Location = new System.Drawing.Point(107, 38);
            this.lbleditcno.Name = "lbleditcno";
            this.lbleditcno.Size = new System.Drawing.Size(0, 12);
            this.lbleditcno.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "编号";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvdate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.Label lblsocre;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblcname;
        private System.Windows.Forms.TextBox txtcno;
        private System.Windows.Forms.Label lblcno;
        private System.Windows.Forms.DataGridView dgvdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txteditscore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txteditname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbleditcno;
        private System.Windows.Forms.Label label4;
    }
}

