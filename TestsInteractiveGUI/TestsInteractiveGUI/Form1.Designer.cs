namespace TestsInteractiveGUI
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl1.Location = new System.Drawing.Point(24, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(175, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter 5 Test Scores";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(28, 78);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(57, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(180, 78);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(57, 20);
            this.txt3.TabIndex = 2;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(106, 127);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(57, 20);
            this.txt5.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(106, 78);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(57, 20);
            this.txt2.TabIndex = 4;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(28, 127);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(57, 20);
            this.txt4.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(28, 183);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(83, 53);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Click For Average";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(138, 195);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(99, 41);
            this.lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblResult;
    }
}

