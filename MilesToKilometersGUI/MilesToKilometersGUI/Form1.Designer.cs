namespace MilesToKilometersGUI
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
            this.btnCon = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(73, 104);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(81, 55);
            this.btnCon.TabIndex = 2;
            this.btnCon.Text = "Click to convert";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(307, 131);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(151, 28);
            this.lblResult.TabIndex = 3;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMiles.Location = new System.Drawing.Point(69, 37);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(104, 24);
            this.lblMiles.TabIndex = 4;
            this.lblMiles.Text = "Enter Miles";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(309, 49);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(148, 20);
            this.text1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox text1;
    }
}

