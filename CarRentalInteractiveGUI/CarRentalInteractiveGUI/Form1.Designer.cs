namespace CarRentalInteractiveGUI
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
            this.lblDays = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.lblMiles = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDays.Location = new System.Drawing.Point(73, 39);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(167, 24);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Enter Days Rented";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(279, 39);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(161, 20);
            this.text1.TabIndex = 1;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMiles.Location = new System.Drawing.Point(73, 100);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(163, 24);
            this.lblMiles.TabIndex = 2;
            this.lblMiles.Text = "Enter Miles Driven";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(279, 104);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(161, 20);
            this.text2.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(77, 182);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(113, 34);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Click to calculate";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Location = new System.Drawing.Point(279, 182);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(161, 24);
            this.lblresult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.lblDays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblresult;
    }
}

