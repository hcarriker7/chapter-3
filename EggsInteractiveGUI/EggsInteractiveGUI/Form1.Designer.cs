namespace EggsInteractiveGUI
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
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(55, 52);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(110, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter Chicken 1 Eggs";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(55, 156);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(110, 13);
            this.lbl5.TabIndex = 1;
            this.lbl5.Text = "Enter Chicken 5 Eggs";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(55, 129);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(110, 13);
            this.lbl4.TabIndex = 2;
            this.lbl4.Text = "Enter Chicken 4 Eggs";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(55, 104);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(110, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Enter Chicken 3 Eggs";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(55, 78);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(110, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Enter Chicken 2 Eggs";
            this.lbl2.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(226, 52);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(141, 20);
            this.txt1.TabIndex = 5;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(226, 126);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(141, 20);
            this.txt4.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(226, 78);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(141, 20);
            this.txt2.TabIndex = 7;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(226, 104);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(141, 20);
            this.txt3.TabIndex = 8;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(226, 152);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(141, 20);
            this.txt5.TabIndex = 9;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(58, 199);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(119, 37);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Click to Calculate";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(226, 199);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(153, 37);
            this.lblResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblResult;
    }
}

