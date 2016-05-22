namespace Zajecia02
{
    partial class SelectId
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
            this.txtBID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(141, 32);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(92, 26);
            this.txtBID.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(30, 35);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(34, 96);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(85, 78);
            this.btnDelete2.TabIndex = 2;
            this.btnDelete2.Text = "Delete Selected";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.Location = new System.Drawing.Point(158, 96);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(90, 78);
            this.btnUpdate2.TabIndex = 3;
            this.btnUpdate2.Text = "Update Selected";
            this.btnUpdate2.UseVisualStyleBackColor = true;
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate2_Click);
            // 
            // SelectId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 206);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtBID);
            this.Name = "SelectId";
            this.Text = "DeleteSelectId";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnUpdate2;
    }
}