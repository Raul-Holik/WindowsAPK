namespace MojaPrvaWindowsAplikacija
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
            this.txtUnosBrA = new System.Windows.Forms.TextBox();
            this.txtUnosBrB = new System.Windows.Forms.TextBox();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzracun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnosBrA
            // 
            this.txtUnosBrA.Location = new System.Drawing.Point(108, 77);
            this.txtUnosBrA.Name = "txtUnosBrA";
            this.txtUnosBrA.Size = new System.Drawing.Size(100, 20);
            this.txtUnosBrA.TabIndex = 0;
            // 
            // txtUnosBrB
            // 
            this.txtUnosBrB.Location = new System.Drawing.Point(429, 77);
            this.txtUnosBrB.Name = "txtUnosBrB";
            this.txtUnosBrB.Size = new System.Drawing.Size(100, 20);
            this.txtUnosBrB.TabIndex = 1;
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(108, 247);
            this.txtRez.Name = "txtRez";
            this.txtRez.ReadOnly = true;
            this.txtRez.Size = new System.Drawing.Size(100, 20);
            this.txtRez.TabIndex = 2;
            this.txtRez.TabStop = false;
            this.txtRez.TextChanged += new System.EventHandler(this.txtRez_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BrojA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BrojB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zbroj";
            // 
            // btnIzracun
            // 
            this.btnIzracun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzracun.Location = new System.Drawing.Point(453, 243);
            this.btnIzracun.Name = "btnIzracun";
            this.btnIzracun.Size = new System.Drawing.Size(75, 23);
            this.btnIzracun.TabIndex = 2;
            this.btnIzracun.Text = "Izracunaj";
            this.btnIzracun.UseVisualStyleBackColor = true;
            this.btnIzracun.Click += new System.EventHandler(this.btnIzracun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzracun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.txtUnosBrB);
            this.Controls.Add(this.txtUnosBrA);
            this.Name = "Form1";
            this.Text = "MojaPrvaWindowsAplikacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosBrA;
        private System.Windows.Forms.TextBox txtUnosBrB;
        private System.Windows.Forms.TextBox txtRez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzracun;
    }
}

