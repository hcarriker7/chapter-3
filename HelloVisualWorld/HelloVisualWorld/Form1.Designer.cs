namespace HelloVisualWorld
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
            this.btnhere = new System.Windows.Forms.Button();
            this.lblhello = new System.Windows.Forms.Label();
            this.btnGoodbye = new System.Windows.Forms.Button();
            this.btnReallyLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhere
            // 
            this.btnhere.Location = new System.Drawing.Point(69, 99);
            this.btnhere.Name = "btnhere";
            this.btnhere.Size = new System.Drawing.Size(80, 28);
            this.btnhere.TabIndex = 0;
            this.btnhere.Text = "Click Here";
            this.btnhere.UseVisualStyleBackColor = true;
            this.btnhere.Click += new System.EventHandler(this.btnhere_Click);
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.Location = new System.Drawing.Point(66, 66);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(96, 13);
            this.lblhello.TabIndex = 1;
            this.lblhello.Text = "Hello, Visual World";
            this.lblhello.Visible = false;
            // 
            // btnGoodbye
            // 
            this.btnGoodbye.Location = new System.Drawing.Point(69, 165);
            this.btnGoodbye.Name = "btnGoodbye";
            this.btnGoodbye.Size = new System.Drawing.Size(80, 28);
            this.btnGoodbye.TabIndex = 2;
            this.btnGoodbye.Text = "Click Me Last";
            this.btnGoodbye.UseVisualStyleBackColor = true;
            this.btnGoodbye.Click += new System.EventHandler(this.btnGoodbye_Click);
            // 
            // btnReallyLast
            // 
            this.btnReallyLast.Location = new System.Drawing.Point(69, 219);
            this.btnReallyLast.Name = "btnReallyLast";
            this.btnReallyLast.Size = new System.Drawing.Size(80, 52);
            this.btnReallyLast.TabIndex = 3;
            this.btnReallyLast.Text = "No Really Click Me Last";
            this.btnReallyLast.UseVisualStyleBackColor = true;
            this.btnReallyLast.Click += new System.EventHandler(this.btnReallyLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReallyLast);
            this.Controls.Add(this.btnGoodbye);
            this.Controls.Add(this.lblhello);
            this.Controls.Add(this.btnhere);
            this.Name = "Form1";
            this.Text = "HelloVisualWorld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhere;
        private System.Windows.Forms.Label lblhello;
        private System.Windows.Forms.Button btnGoodbye;
        private System.Windows.Forms.Button btnReallyLast;
    }
}

