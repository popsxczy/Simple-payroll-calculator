namespace payroll
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtww = new System.Windows.Forms.TextBox();
            this.txthr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgross = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsss = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.txtpagibig = new System.Windows.Forms.TextBox();
            this.txtphil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(290, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(348, 38);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employer\'s Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtww
            // 
            this.txtww.Location = new System.Drawing.Point(429, 128);
            this.txtww.Name = "txtww";
            this.txtww.Size = new System.Drawing.Size(209, 38);
            this.txtww.TabIndex = 2;
            this.txtww.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txthr
            // 
            this.txthr.Location = new System.Drawing.Point(290, 182);
            this.txthr.Name = "txthr";
            this.txthr.Size = new System.Drawing.Size(348, 38);
            this.txthr.TabIndex = 3;
            this.txthr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hourly Pay Rate:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "GROSS PAY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "== DEDUCTION ==";
            // 
            // txtgross
            // 
            this.txtgross.Location = new System.Drawing.Point(290, 281);
            this.txtgross.Name = "txtgross";
            this.txtgross.Size = new System.Drawing.Size(348, 38);
            this.txtgross.TabIndex = 9;
            this.txtgross.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "SSS (20%):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtsss
            // 
            this.txtsss.Location = new System.Drawing.Point(290, 361);
            this.txtsss.Name = "txtsss";
            this.txtsss.Size = new System.Drawing.Size(348, 38);
            this.txtsss.TabIndex = 12;
            // 
            // txttax
            // 
            this.txttax.Location = new System.Drawing.Point(290, 415);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(348, 38);
            this.txttax.TabIndex = 13;
            // 
            // txtpagibig
            // 
            this.txtpagibig.Location = new System.Drawing.Point(290, 466);
            this.txtpagibig.Name = "txtpagibig";
            this.txtpagibig.Size = new System.Drawing.Size(348, 38);
            this.txtpagibig.TabIndex = 15;
            // 
            // txtphil
            // 
            this.txtphil.Location = new System.Drawing.Point(290, 519);
            this.txtphil.Name = "txtphil";
            this.txtphil.Size = new System.Drawing.Size(348, 38);
            this.txtphil.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "PHILHEALTH (10%):";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtphil);
            this.groupBox1.Controls.Add(this.txtpagibig);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttax);
            this.groupBox1.Controls.Add(this.txtsss);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtgross);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txthr);
            this.groupBox1.Controls.Add(this.txtww);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 643);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SIMPLE PAYROLL SYSTEM";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(290, 576);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(348, 38);
            this.txttotal.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "TOTAL DEDUCTIONS:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "PAGIBIG (5%):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "TAX (25%):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(350, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "COMPUTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Hours Wokred in a Week:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(25, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 33);
            this.label11.TabIndex = 4;
            this.label11.Text = "NETPAY:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.txtnet);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(30, 661);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 71);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".";
            // 
            // txtnet
            // 
            this.txtnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnet.Location = new System.Drawing.Point(159, 16);
            this.txtnet.Name = "txtnet";
            this.txtnet.Size = new System.Drawing.Size(491, 38);
            this.txtnet.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(706, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtww;
        private System.Windows.Forms.TextBox txthr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgross;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsss;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.TextBox txtpagibig;
        private System.Windows.Forms.TextBox txtphil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnet;
    }
}

