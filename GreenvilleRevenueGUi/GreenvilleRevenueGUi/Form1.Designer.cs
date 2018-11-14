namespace GreenvilleRevenueGUi
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl1.Location = new System.Drawing.Point(34, 36);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(294, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter Last years Number of Contestants";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl2.Location = new System.Drawing.Point(34, 83);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(296, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Enter This Years Number of Contestants";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(363, 36);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(170, 20);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(363, 85);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(170, 20);
            this.txt2.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl3.Location = new System.Drawing.Point(34, 125);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(144, 20);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Revenue Expected";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(38, 169);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(96, 64);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Click To Calculate";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl4
            // 
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl4.Location = new System.Drawing.Point(363, 125);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(170, 23);
            this.lbl4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Greenville";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl4;
    }
}

