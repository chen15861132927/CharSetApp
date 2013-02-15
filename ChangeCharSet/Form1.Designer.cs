namespace ChangeCharSet
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chbjsp = new System.Windows.Forms.CheckBox();
            this.chbjs = new System.Windows.Forms.CheckBox();
            this.chbjava = new System.Windows.Forms.CheckBox();
            this.chbxml = new System.Windows.Forms.CheckBox();
            this.chbcss = new System.Windows.Forms.CheckBox();
            this.chbhtml = new System.Windows.Forms.CheckBox();
            this.chbhtm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "转换编码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 21);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "目标编码：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 166);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(355, 116);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "要处理的后缀：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "选择文件夹";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "选择文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chbjsp
            // 
            this.chbjsp.AutoSize = true;
            this.chbjsp.Location = new System.Drawing.Point(433, 111);
            this.chbjsp.Name = "chbjsp";
            this.chbjsp.Size = new System.Drawing.Size(48, 16);
            this.chbjsp.TabIndex = 15;
            this.chbjsp.Text = ".jsp";
            this.chbjsp.UseVisualStyleBackColor = true;
            // 
            // chbjs
            // 
            this.chbjs.AutoSize = true;
            this.chbjs.Location = new System.Drawing.Point(433, 133);
            this.chbjs.Name = "chbjs";
            this.chbjs.Size = new System.Drawing.Size(42, 16);
            this.chbjs.TabIndex = 16;
            this.chbjs.Text = ".js";
            this.chbjs.UseVisualStyleBackColor = true;
            // 
            // chbjava
            // 
            this.chbjava.AutoSize = true;
            this.chbjava.Location = new System.Drawing.Point(432, 155);
            this.chbjava.Name = "chbjava";
            this.chbjava.Size = new System.Drawing.Size(54, 16);
            this.chbjava.TabIndex = 17;
            this.chbjava.Text = ".java";
            this.chbjava.UseVisualStyleBackColor = true;
            // 
            // chbxml
            // 
            this.chbxml.AutoSize = true;
            this.chbxml.Location = new System.Drawing.Point(517, 155);
            this.chbxml.Name = "chbxml";
            this.chbxml.Size = new System.Drawing.Size(48, 16);
            this.chbxml.TabIndex = 20;
            this.chbxml.Text = ".xml";
            this.chbxml.UseVisualStyleBackColor = true;
            // 
            // chbcss
            // 
            this.chbcss.AutoSize = true;
            this.chbcss.Location = new System.Drawing.Point(517, 133);
            this.chbcss.Name = "chbcss";
            this.chbcss.Size = new System.Drawing.Size(48, 16);
            this.chbcss.TabIndex = 19;
            this.chbcss.Text = ".css";
            this.chbcss.UseVisualStyleBackColor = true;
            // 
            // chbhtml
            // 
            this.chbhtml.AutoSize = true;
            this.chbhtml.Location = new System.Drawing.Point(517, 111);
            this.chbhtml.Name = "chbhtml";
            this.chbhtml.Size = new System.Drawing.Size(54, 16);
            this.chbhtml.TabIndex = 18;
            this.chbhtml.Text = ".html";
            this.chbhtml.UseVisualStyleBackColor = true;
            // 
            // chbhtm
            // 
            this.chbhtm.AutoSize = true;
            this.chbhtm.Location = new System.Drawing.Point(601, 111);
            this.chbhtm.Name = "chbhtm";
            this.chbhtm.Size = new System.Drawing.Size(48, 16);
            this.chbhtm.TabIndex = 21;
            this.chbhtm.Text = ".htm";
            this.chbhtm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 294);
            this.Controls.Add(this.chbhtm);
            this.Controls.Add(this.chbxml);
            this.Controls.Add(this.chbcss);
            this.Controls.Add(this.chbhtml);
            this.Controls.Add(this.chbjava);
            this.Controls.Add(this.chbjs);
            this.Controls.Add(this.chbjsp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chbjsp;
        private System.Windows.Forms.CheckBox chbjs;
        private System.Windows.Forms.CheckBox chbjava;
        private System.Windows.Forms.CheckBox chbxml;
        private System.Windows.Forms.CheckBox chbcss;
        private System.Windows.Forms.CheckBox chbhtml;
        private System.Windows.Forms.CheckBox chbhtm;
    }
}

