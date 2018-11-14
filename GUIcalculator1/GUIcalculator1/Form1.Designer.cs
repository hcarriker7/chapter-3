namespace GUIcalculator1
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl1.Location = new System.Drawing.Point(81, 87);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(141, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter a number";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl2.Location = new System.Drawing.Point(80, 133);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(195, 24);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Enter another number";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(313, 87);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(149, 20);
            this.text1.TabIndex = 2;
            this.text1.Text = "5";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(313, 135);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(148, 20);
            this.text2.TabIndex = 3;
            this.text2.Text = "5";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(85, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 26);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Click to Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Location = new System.Drawing.Point(312, 192);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(149, 19);
            this.lblresult.TabIndex = 6;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(85, 232);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(73, 38);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "Click to Subtract";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(85, 294);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(73, 38);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Text = "Click to Multiply";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(85, 353);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(73, 38);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "Click to Divide";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(85, 400);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(73, 38);
            this.btnMod.TabIndex = 10;
            this.btnMod.Text = "Click to Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMod;
    }
}

