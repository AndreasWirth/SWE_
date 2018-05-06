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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btAddCustomer = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.tbBallance = new System.Windows.Forms.MaskedTextBox();
            this.tbCustomerNumber = new System.Windows.Forms.MaskedTextBox();
            this.errProvEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGenerateID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Customer Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ballance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "E-Mail Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(185, 110);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(164, 22);
            this.tbFirstName.TabIndex = 11;
            // 
            // btAddCustomer
            // 
            this.btAddCustomer.Location = new System.Drawing.Point(38, 247);
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Size = new System.Drawing.Size(100, 35);
            this.btAddCustomer.TabIndex = 18;
            this.btAddCustomer.Text = "Add";
            this.btAddCustomer.UseVisualStyleBackColor = true;
            this.btAddCustomer.Click += new System.EventHandler(this.btAddCustomer_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(185, 247);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(100, 35);
            this.btnCancle.TabIndex = 19;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(185, 143);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(164, 22);
            this.tbLastName.TabIndex = 20;
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(185, 178);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(164, 22);
            this.tbEMail.TabIndex = 21;
            this.tbEMail.TextChanged += new System.EventHandler(this.tbEMail_TextChanged);
            // 
            // tbBallance
            // 
            this.tbBallance.Location = new System.Drawing.Point(185, 207);
            this.tbBallance.Mask = "00000.00";
            this.tbBallance.Name = "tbBallance";
            this.tbBallance.Size = new System.Drawing.Size(164, 22);
            this.tbBallance.TabIndex = 24;
            this.tbBallance.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tbCustomerNumber
            // 
            this.tbCustomerNumber.Location = new System.Drawing.Point(185, 74);
            this.tbCustomerNumber.Mask = "00000";
            this.tbCustomerNumber.Name = "tbCustomerNumber";
            this.tbCustomerNumber.Size = new System.Drawing.Size(164, 22);
            this.tbCustomerNumber.TabIndex = 25;
            // 
            // errProvEmail
            // 
            this.errProvEmail.ContainerControl = this;
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.Location = new System.Drawing.Point(220, 33);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(100, 35);
            this.btnGenerateID.TabIndex = 26;
            this.btnGenerateID.Text = "Generate ID";
            this.btnGenerateID.UseVisualStyleBackColor = true;
            this.btnGenerateID.Click += new System.EventHandler(this.btnGenerateID_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 301);
            this.Controls.Add(this.btnGenerateID);
            this.Controls.Add(this.tbCustomerNumber);
            this.Controls.Add(this.tbBallance);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btAddCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstName);
            this.Name = "NewCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.NewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btAddCustomer;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.MaskedTextBox tbBallance;
        private System.Windows.Forms.MaskedTextBox tbCustomerNumber;
        private System.Windows.Forms.ErrorProvider errProvEmail;
        private System.Windows.Forms.Button btnGenerateID;
    }
}