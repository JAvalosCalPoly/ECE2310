namespace GroupProject_BMI_2_1
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
            this.Ft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.In = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Comp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BMI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Hres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ft
            // 
            this.Ft.Location = new System.Drawing.Point(146, 35);
            this.Ft.Name = "Ft";
            this.Ft.Size = new System.Drawing.Size(100, 31);
            this.Ft.TabIndex = 0;
            this.Ft.TextChanged += new System.EventHandler(this.Ft_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height:";
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(280, 35);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(100, 31);
            this.In.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "(Feet)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "(Inches)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Your";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Height:";
            // 
            // Lbs
            // 
            this.Lbs.Location = new System.Drawing.Point(146, 139);
            this.Lbs.Name = "Lbs";
            this.Lbs.Size = new System.Drawing.Size(100, 31);
            this.Lbs.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "(Pounds)";
            // 
            // Comp
            // 
            this.Comp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Comp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comp.Location = new System.Drawing.Point(56, 240);
            this.Comp.Name = "Comp";
            this.Comp.Size = new System.Drawing.Size(324, 76);
            this.Comp.TabIndex = 10;
            this.Comp.Text = "Computer BMI";
            this.Comp.UseVisualStyleBackColor = false;
            this.Comp.Click += new System.EventHandler(this.Comp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(155, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "Your BMI";
            // 
            // BMI
            // 
            this.BMI.Location = new System.Drawing.Point(174, 389);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(100, 31);
            this.BMI.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(146, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 31);
            this.label9.TabIndex = 13;
            this.label9.Text = "You Are...";
            // 
            // Hres
            // 
            this.Hres.Location = new System.Drawing.Point(112, 467);
            this.Hres.Name = "Hres";
            this.Hres.Size = new System.Drawing.Size(206, 31);
            this.Hres.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 615);
            this.Controls.Add(this.Hres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Comp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lbs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.In);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox In;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Lbs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Comp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BMI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Hres;
    }
}

