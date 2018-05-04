namespace CustomerData
{
    partial class NewCustomer
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
            this.components = new System.ComponentModel.Container();
            this.labelCustomNumber = new System.Windows.Forms.Label();
            this.labelBallance = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.lableFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btAddCustomer = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.tbBallance = new System.Windows.Forms.MaskedTextBox();
            this.tbCustomerNumber = new System.Windows.Forms.MaskedTextBox();
            this.errProvEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustomNumber
            // 
            this.labelCustomNumber.AutoSize = true;
            this.labelCustomNumber.Location = new System.Drawing.Point(51, 183);
            this.labelCustomNumber.Name = "labelCustomNumber";
            this.labelCustomNumber.Size = new System.Drawing.Size(122, 17);
            this.labelCustomNumber.TabIndex = 17;
            this.labelCustomNumber.Text = "Customer Number";
            // 
            // labelBallance
            // 
            this.labelBallance.AutoSize = true;
            this.labelBallance.Location = new System.Drawing.Point(51, 145);
            this.labelBallance.Name = "labelBallance";
            this.labelBallance.Size = new System.Drawing.Size(62, 17);
            this.labelBallance.TabIndex = 15;
            this.labelBallance.Text = "Ballance";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(51, 116);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(95, 17);
            this.labelEMail.TabIndex = 14;
            this.labelEMail.Text = "E-Mail Adress";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(51, 81);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 13;
            this.labelLastName.Text = "Last Name";
            // 
            // lableFirstName
            // 
            this.lableFirstName.AutoSize = true;
            this.lableFirstName.Location = new System.Drawing.Point(51, 48);
            this.lableFirstName.Name = "lableFirstName";
            this.lableFirstName.Size = new System.Drawing.Size(76, 17);
            this.lableFirstName.TabIndex = 12;
            this.lableFirstName.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(243, 48);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(164, 22);
            this.tbFirstName.TabIndex = 11;
            // 
            // btAddCustomer
            // 
            this.btAddCustomer.Location = new System.Drawing.Point(105, 226);
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Size = new System.Drawing.Size(100, 35);
            this.btAddCustomer.TabIndex = 18;
            this.btAddCustomer.Text = "Add";
            this.btAddCustomer.UseVisualStyleBackColor = true;
            this.btAddCustomer.Click += new System.EventHandler(this.btAddCustomer_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(252, 226);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(100, 35);
            this.btnCancle.TabIndex = 19;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(243, 81);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(164, 22);
            this.tbLastName.TabIndex = 20;
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(243, 116);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(164, 22);
            this.tbEMail.TabIndex = 21;
            // 
            // tbBallance
            // 
            this.tbBallance.Location = new System.Drawing.Point(243, 145);
            this.tbBallance.Mask = "00000";
            this.tbBallance.Name = "tbBallance";
            this.tbBallance.Size = new System.Drawing.Size(164, 22);
            this.tbBallance.TabIndex = 24;
            this.tbBallance.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tbCustomerNumber
            // 
            this.tbCustomerNumber.Location = new System.Drawing.Point(243, 180);
            this.tbCustomerNumber.Mask = "00000";
            this.tbCustomerNumber.Name = "tbCustomerNumber";
            this.tbCustomerNumber.Size = new System.Drawing.Size(164, 22);
            this.tbCustomerNumber.TabIndex = 25;
            // 
            // errProvEmail
            // 
            this.errProvEmail.ContainerControl = this;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 301);
            this.Controls.Add(this.tbCustomerNumber);
            this.Controls.Add(this.tbBallance);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btAddCustomer);
            this.Controls.Add(this.labelCustomNumber);
            this.Controls.Add(this.labelBallance);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.lableFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            this.Load += new System.EventHandler(this.NewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomNumber;
        private System.Windows.Forms.Label labelBallance;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label lableFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btAddCustomer;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.MaskedTextBox tbBallance;
        private System.Windows.Forms.MaskedTextBox tbCustomerNumber;
        private System.Windows.Forms.ErrorProvider errProvEmail;
    }
}