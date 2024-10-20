namespace appdev_PETA
{
    partial class FrmDelete
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
            this.BtnDelDelete = new System.Windows.Forms.Button();
            this.txtDelEmail = new System.Windows.Forms.TextBox();
            this.txtDelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDelDelete
            // 
            this.BtnDelDelete.Location = new System.Drawing.Point(75, 182);
            this.BtnDelDelete.Name = "BtnDelDelete";
            this.BtnDelDelete.Size = new System.Drawing.Size(86, 33);
            this.BtnDelDelete.TabIndex = 0;
            this.BtnDelDelete.Text = "Delete";
            this.BtnDelDelete.UseVisualStyleBackColor = true;
            this.BtnDelDelete.Click += new System.EventHandler(this.BtnDelDelete_Click);
            // 
            // txtDelEmail
            // 
            this.txtDelEmail.Location = new System.Drawing.Point(34, 115);
            this.txtDelEmail.Name = "txtDelEmail";
            this.txtDelEmail.Size = new System.Drawing.Size(286, 22);
            this.txtDelEmail.TabIndex = 1;
            // 
            // txtDelName
            // 
            this.txtDelName.Location = new System.Drawing.Point(34, 45);
            this.txtDelName.Name = "txtDelName";
            this.txtDelName.Size = new System.Drawing.Size(286, 22);
            this.txtDelName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(198, 182);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(86, 33);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // FrmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 265);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelName);
            this.Controls.Add(this.txtDelEmail);
            this.Controls.Add(this.BtnDelDelete);
            this.Name = "FrmDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelDelete;
        private System.Windows.Forms.TextBox txtDelEmail;
        private System.Windows.Forms.TextBox txtDelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel;
    }
}