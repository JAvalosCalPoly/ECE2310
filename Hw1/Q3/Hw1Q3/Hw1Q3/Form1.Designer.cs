namespace Hw1Q3
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
            this.label1 = new System.Windows.Forms.Label();
            this.hwk = new System.Windows.Forms.TextBox();
            this.quz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "homework (10%)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hwk
            // 
            this.hwk.Location = new System.Drawing.Point(190, 36);
            this.hwk.Name = "hwk";
            this.hwk.Size = new System.Drawing.Size(170, 31);
            this.hwk.TabIndex = 1;
            // 
            // quz
            // 
            this.quz.Location = new System.Drawing.Point(539, 39);
            this.quz.Name = "quz";
            this.quz.Size = new System.Drawing.Size(170, 31);
            this.quz.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quizzes (20%)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // prj
            // 
            this.prj.Location = new System.Drawing.Point(190, 142);
            this.prj.Name = "prj";
            this.prj.Size = new System.Drawing.Size(170, 31);
            this.prj.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Projects (25%)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // exm
            // 
            this.exm.Location = new System.Drawing.Point(507, 142);
            this.exm.Name = "exm";
            this.exm.Size = new System.Drawing.Size(170, 31);
            this.exm.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Exam (20%)";
            // 
            // fex
            // 
            this.fex.Location = new System.Drawing.Point(385, 259);
            this.fex.Name = "fex";
            this.fex.Size = new System.Drawing.Size(170, 31);
            this.fex.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Final Exam (25%)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(86, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 107);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate Grade";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grd
            // 
            this.grd.Location = new System.Drawing.Point(467, 366);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(170, 31);
            this.grd.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Final Grade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hwk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hwk;
        private System.Windows.Forms.TextBox quz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox grd;
        private System.Windows.Forms.Label label6;
    }
}

