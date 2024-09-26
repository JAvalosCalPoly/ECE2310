namespace factorial_inclass_test
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
            this.Uin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.factbun = new System.Windows.Forms.Button();
            this.Out1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Uin
            // 
            this.Uin.Location = new System.Drawing.Point(289, 12);
            this.Uin.Name = "Uin";
            this.Uin.Size = new System.Drawing.Size(211, 31);
            this.Uin.TabIndex = 0;
            this.Uin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a positive integer n:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // factbun
            // 
            this.factbun.BackColor = System.Drawing.SystemColors.ControlDark;
            this.factbun.Location = new System.Drawing.Point(31, 93);
            this.factbun.Name = "factbun";
            this.factbun.Size = new System.Drawing.Size(252, 134);
            this.factbun.TabIndex = 2;
            this.factbun.Text = "N!";
            this.factbun.UseVisualStyleBackColor = false;
            this.factbun.Click += new System.EventHandler(this.factbun_Click);
            // 
            // Out1
            // 
            this.Out1.FormattingEnabled = true;
            this.Out1.ItemHeight = 25;
            this.Out1.Location = new System.Drawing.Point(31, 258);
            this.Out1.Name = "Out1";
            this.Out1.Size = new System.Drawing.Size(469, 154);
            this.Out1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 452);
            this.Controls.Add(this.Out1);
            this.Controls.Add(this.factbun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Uin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button factbun;
        private System.Windows.Forms.ListBox Out1;
    }
}

