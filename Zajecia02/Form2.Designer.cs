namespace Zajecia02
{
    partial class Form2
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelWhen = new System.Windows.Forms.Label();
            this.txtBTitle = new System.Windows.Forms.TextBox();
            this.txtBDesc = new System.Windows.Forms.TextBox();
            this.txtBWhen = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(59, 63);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(59, 120);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(89, 20);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            // 
            // labelWhen
            // 
            this.labelWhen.AutoSize = true;
            this.labelWhen.Location = new System.Drawing.Point(59, 181);
            this.labelWhen.Name = "labelWhen";
            this.labelWhen.Size = new System.Drawing.Size(51, 20);
            this.labelWhen.TabIndex = 2;
            this.labelWhen.Text = "When";
            // 
            // txtBTitle
            // 
            this.txtBTitle.Location = new System.Drawing.Point(269, 63);
            this.txtBTitle.Name = "txtBTitle";
            this.txtBTitle.Size = new System.Drawing.Size(214, 26);
            this.txtBTitle.TabIndex = 3;
            // 
            // txtBDesc
            // 
            this.txtBDesc.Location = new System.Drawing.Point(269, 120);
            this.txtBDesc.Name = "txtBDesc";
            this.txtBDesc.Size = new System.Drawing.Size(214, 26);
            this.txtBDesc.TabIndex = 4;
            // 
            // txtBWhen
            // 
            this.txtBWhen.Location = new System.Drawing.Point(269, 175);
            this.txtBWhen.Name = "txtBWhen";
            this.txtBWhen.Size = new System.Drawing.Size(214, 26);
            this.txtBWhen.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(63, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 39);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 448);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBWhen);
            this.Controls.Add(this.txtBDesc);
            this.Controls.Add(this.txtBTitle);
            this.Controls.Add(this.labelWhen);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelWhen;
        private System.Windows.Forms.TextBox txtBTitle;
        private System.Windows.Forms.TextBox txtBDesc;
        private System.Windows.Forms.TextBox txtBWhen;
        private System.Windows.Forms.Button btnSave;
    }
}