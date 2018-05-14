namespace CustomerData
{
    partial class ChangeCustomer
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
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btChangeCustomer = new System.Windows.Forms.Button();
            this.labelCustomerNumber = new System.Windows.Forms.Label();
            this.labelBallance = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.MaskedTextBox();
            this.tbBallance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBallance = new System.Windows.Forms.TextBox();
            this.errProvEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(226, 184);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(164, 22);
            this.tbEMail.TabIndex = 33;
            this.tbEMail.TextChanged += new System.EventHandler(this.tbEMail_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(226, 154);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(164, 22);
            this.tbLastName.TabIndex = 32;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(235, 274);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(100, 35);
            this.btnCancle.TabIndex = 31;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btChangeCustomer
            // 
            this.btChangeCustomer.Location = new System.Drawing.Point(88, 274);
            this.btChangeCustomer.Name = "btChangeCustomer";
            this.btChangeCustomer.Size = new System.Drawing.Size(100, 35);
            this.btChangeCustomer.TabIndex = 30;
            this.btChangeCustomer.Text = "Change";
            this.btChangeCustomer.UseVisualStyleBackColor = true;
            this.btChangeCustomer.Click += new System.EventHandler(this.btAddCustomer_Click);
            // 
            // labelCustomerNumber
            // 
            this.labelCustomerNumber.AutoSize = true;
            this.labelCustomerNumber.Location = new System.Drawing.Point(34, 26);
            this.labelCustomerNumber.Name = "labelCustomerNumber";
            this.labelCustomerNumber.Size = new System.Drawing.Size(122, 17);
            this.labelCustomerNumber.TabIndex = 29;
            this.labelCustomerNumber.Text = "Customer Number";
            // 
            // labelBallance
            // 
            this.labelBallance.AutoSize = true;
            this.labelBallance.Location = new System.Drawing.Point(34, 218);
            this.labelBallance.Name = "labelBallance";
            this.labelBallance.Size = new System.Drawing.Size(62, 17);
            this.labelBallance.TabIndex = 28;
            this.labelBallance.Text = "Ballance";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(34, 189);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(95, 17);
            this.labelEMail.TabIndex = 27;
            this.labelEMail.Text = "E-Mail Adress";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(34, 154);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 26;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(34, 121);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelFirstName.TabIndex = 25;
            this.labelFirstName.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(226, 121);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(164, 22);
            this.tbFirstName.TabIndex = 24;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(96, 66);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(239, 35);
            this.btnGetCustomer.TabIndex = 36;
            this.btnGetCustomer.Text = "Get Customer Data";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(226, 23);
            this.tbID.Mask = "00000";
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(164, 22);
            this.tbID.TabIndex = 37;
            this.tbID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbID_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ballance";
            // 
            // tbBallance
            // 
            this.tbBallance.Location = new System.Drawing.Point(226, 218);
            this.tbBallance.Name = "tbBallance";
            this.tbBallance.ReadOnly = true;
            this.tbBallance.Size = new System.Drawing.Size(164, 22);
            this.tbBallance.TabIndex = 39;
            // 
            // errProvEmail
            // 
            this.errProvEmail.ContainerControl = this;
            // 
            // ChangeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 352);
            this.Controls.Add(this.tbBallance);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnGetCustomer);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btChangeCustomer);
            this.Controls.Add(this.labelCustomerNumber);
            this.Controls.Add(this.labelBallance);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "ChangeCustomer";
            this.Text = "ChangeCustomer";
            this.Load += new System.EventHandler(this.ChangeCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btChangeCustomer;
        private System.Windows.Forms.Label labelCustomerNumber;
        private System.Windows.Forms.Label labelBallance;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btnGetCustomer;
        private System.Windows.Forms.MaskedTextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBallance;
        private System.Windows.Forms.ErrorProvider errProvEmail;
    }
}