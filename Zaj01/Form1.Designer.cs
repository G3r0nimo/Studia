namespace Zaj01
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
            this.btnDod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Liczba1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLiczba2 = new System.Windows.Forms.TextBox();
            this.txtLiczba1 = new System.Windows.Forms.TextBox();
            this.btnOdj = new System.Windows.Forms.Button();
            this.btndziel = new System.Windows.Forms.Button();
            this.btnmnoz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDod
            // 
            this.btnDod.Location = new System.Drawing.Point(413, 152);
            this.btnDod.Name = "btnDod";
            this.btnDod.Size = new System.Drawing.Size(82, 40);
            this.btnDod.TabIndex = 0;
            this.btnDod.Text = "+";
            this.btnDod.UseVisualStyleBackColor = true;
            this.btnDod.Click += new System.EventHandler(this.btnmnoz_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Liczba1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLiczba2);
            this.groupBox1.Controls.Add(this.txtLiczba1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie";
            // 
            // Liczba1
            // 
            this.Liczba1.AutoSize = true;
            this.Liczba1.Location = new System.Drawing.Point(15, 92);
            this.Liczba1.Name = "Liczba1";
            this.Liczba1.Size = new System.Drawing.Size(62, 20);
            this.Liczba1.TabIndex = 6;
            this.Liczba1.Text = "liczba 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "liczba 1";
            // 
            // txtLiczba2
            // 
            this.txtLiczba2.Location = new System.Drawing.Point(83, 86);
            this.txtLiczba2.Name = "txtLiczba2";
            this.txtLiczba2.Size = new System.Drawing.Size(100, 26);
            this.txtLiczba2.TabIndex = 4;
            // 
            // txtLiczba1
            // 
            this.txtLiczba1.Location = new System.Drawing.Point(83, 45);
            this.txtLiczba1.Name = "txtLiczba1";
            this.txtLiczba1.Size = new System.Drawing.Size(100, 26);
            this.txtLiczba1.TabIndex = 3;
            // 
            // btnOdj
            // 
            this.btnOdj.Location = new System.Drawing.Point(303, 152);
            this.btnOdj.Name = "btnOdj";
            this.btnOdj.Size = new System.Drawing.Size(75, 40);
            this.btnOdj.TabIndex = 4;
            this.btnOdj.Text = "-";
            this.btnOdj.UseVisualStyleBackColor = true;
            this.btnOdj.Click += new System.EventHandler(this.btnmnoz_Click_1);
            // 
            // btndziel
            // 
            this.btndziel.Location = new System.Drawing.Point(303, 84);
            this.btndziel.Name = "btndziel";
            this.btndziel.Size = new System.Drawing.Size(75, 32);
            this.btndziel.TabIndex = 5;
            this.btndziel.Text = "/";
            this.btndziel.UseVisualStyleBackColor = true;
            this.btndziel.Click += new System.EventHandler(this.btnmnoz_Click_1);
            // 
            // btnmnoz
            // 
            this.btnmnoz.Location = new System.Drawing.Point(413, 84);
            this.btnmnoz.Name = "btnmnoz";
            this.btnmnoz.Size = new System.Drawing.Size(82, 32);
            this.btnmnoz.TabIndex = 6;
            this.btnmnoz.Text = "*";
            this.btnmnoz.UseVisualStyleBackColor = true;
            this.btnmnoz.Click += new System.EventHandler(this.btnmnoz_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 358);
            this.Controls.Add(this.btnmnoz);
            this.Controls.Add(this.btndziel);
            this.Controls.Add(this.btnOdj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Liczba1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLiczba2;
        private System.Windows.Forms.TextBox txtLiczba1;
        private System.Windows.Forms.Button btnOdj;
        private System.Windows.Forms.Button btndziel;
        private System.Windows.Forms.Button btnmnoz;
    }
}

