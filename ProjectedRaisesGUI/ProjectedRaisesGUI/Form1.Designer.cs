namespace ProjectedRaisesGUI
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
            this.lblsalary = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.btnRaise = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsalary.Location = new System.Drawing.Point(57, 28);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(232, 24);
            this.lblsalary.TabIndex = 0;
            this.lblsalary.Text = "Enter an employees salary";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(352, 33);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(186, 20);
            this.text1.TabIndex = 1;
            // 
            // btnRaise
            // 
            this.btnRaise.Location = new System.Drawing.Point(100, 128);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(85, 56);
            this.btnRaise.TabIndex = 2;
            this.btnRaise.Text = "Click to see raise";
            this.btnRaise.UseVisualStyleBackColor = true;
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Location = new System.Drawing.Point(352, 128);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(186, 37);
            this.lblresult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnRaise);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.lblsalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button btnRaise;
        private System.Windows.Forms.Label lblresult;
    }
}

