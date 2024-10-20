namespace appdev_PETA
{
    partial class frmEdit
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
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.labas = new System.Windows.Forms.Label();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.lavel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(246, 364);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(86, 34);
            this.btnAddCancel.TabIndex = 19;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(148, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 34);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Edit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.Location = new System.Drawing.Point(35, 294);
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(297, 22);
            this.txtEditAddress.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Address";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(35, 205);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(297, 22);
            this.txtEditEmail.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(35, 131);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(297, 22);
            this.txtAddName.TabIndex = 13;
            // 
            // labas
            // 
            this.labas.AutoSize = true;
            this.labas.Location = new System.Drawing.Point(32, 112);
            this.labas.Name = "labas";
            this.labas.Size = new System.Drawing.Size(44, 16);
            this.labas.TabIndex = 12;
            this.labas.Text = "Name";
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(35, 51);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(297, 22);
            this.txtEditID.TabIndex = 11;
            // 
            // lavel
            // 
            this.lavel.AutoSize = true;
            this.lavel.Location = new System.Drawing.Point(32, 32);
            this.lavel.Name = "lavel";
            this.lavel.Size = new System.Drawing.Size(20, 16);
            this.lavel.TabIndex = 10;
            this.lavel.Text = "ID";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 423);
            this.Controls.Add(this.btnAddCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEditAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEditEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.labas);
            this.Controls.Add(this.txtEditID);
            this.Controls.Add(this.lavel);
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label labas;
        private System.Windows.Forms.TextBox txtEditID;
        private System.Windows.Forms.Label lavel;
    }
}