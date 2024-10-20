namespace appdev_PETA
{
    partial class frmAdd
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
            this.lavel = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.labas = new System.Windows.Forms.Label();
            this.txtAddSex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lavel
            // 
            this.lavel.AutoSize = true;
            this.lavel.Location = new System.Drawing.Point(26, 30);
            this.lavel.Name = "lavel";
            this.lavel.Size = new System.Drawing.Size(44, 16);
            this.lavel.TabIndex = 0;
            this.lavel.Text = "Name";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(29, 49);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(297, 22);
            this.txtAddName.TabIndex = 1;
            this.txtAddName.TextChanged += new System.EventHandler(this.txtAddName_TextChanged);
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(29, 129);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(297, 22);
            this.txtAddEmail.TabIndex = 3;
            // 
            // labas
            // 
            this.labas.AutoSize = true;
            this.labas.Location = new System.Drawing.Point(26, 110);
            this.labas.Name = "labas";
            this.labas.Size = new System.Drawing.Size(41, 16);
            this.labas.TabIndex = 2;
            this.labas.Text = "Email";
            // 
            // txtAddSex
            // 
            this.txtAddSex.Location = new System.Drawing.Point(29, 203);
            this.txtAddSex.Name = "txtAddSex";
            this.txtAddSex.Size = new System.Drawing.Size(297, 22);
            this.txtAddSex.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sex";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(29, 285);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(297, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(240, 362);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(86, 34);
            this.btnAddCancel.TabIndex = 9;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 443);
            this.Controls.Add(this.btnAddCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddEmail);
            this.Controls.Add(this.labas);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.lavel);
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdd";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lavel;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label labas;
        private System.Windows.Forms.TextBox txtAddSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddCancel;
    }
}