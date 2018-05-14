namespace CustomerData
{
    partial class Booking
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
            this.btnPayIn = new System.Windows.Forms.Button();
            this.btnPayOut = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.MaskedTextBox();
            this.tbCustomerNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelCustomerNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPayIn
            // 
            this.btnPayIn.Location = new System.Drawing.Point(55, 117);
            this.btnPayIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayIn.Name = "btnPayIn";
            this.btnPayIn.Size = new System.Drawing.Size(100, 34);
            this.btnPayIn.TabIndex = 2;
            this.btnPayIn.Text = "Pay In";
            this.btnPayIn.UseVisualStyleBackColor = true;
            this.btnPayIn.Click += new System.EventHandler(this.btnPayIn_Click);
            // 
            // btnPayOut
            // 
            this.btnPayOut.Location = new System.Drawing.Point(197, 117);
            this.btnPayOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayOut.Name = "btnPayOut";
            this.btnPayOut.Size = new System.Drawing.Size(100, 34);
            this.btnPayOut.TabIndex = 3;
            this.btnPayOut.Text = "Pay Out";
            this.btnPayOut.UseVisualStyleBackColor = true;
            this.btnPayOut.Click += new System.EventHandler(this.btnPayOut_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(155, 63);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(56, 17);
            this.labelAmount.TabIndex = 13;
            this.labelAmount.Text = "Amount";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(347, 117);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 34);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(236, 58);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAmount.Mask = "00000.00";
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 22);
            this.tbAmount.TabIndex = 15;
            // 
            // tbCustomerNumber
            // 
            this.tbCustomerNumber.Location = new System.Drawing.Point(236, 15);
            this.tbCustomerNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCustomerNumber.Mask = "00000";
            this.tbCustomerNumber.Name = "tbCustomerNumber";
            this.tbCustomerNumber.Size = new System.Drawing.Size(100, 22);
            this.tbCustomerNumber.TabIndex = 29;
            this.tbCustomerNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbCustomerNumber_MaskInputRejected);
            // 
            // labelCustomerNumber
            // 
            this.labelCustomerNumber.AutoSize = true;
            this.labelCustomerNumber.Location = new System.Drawing.Point(97, 17);
            this.labelCustomerNumber.Name = "labelCustomerNumber";
            this.labelCustomerNumber.Size = new System.Drawing.Size(122, 17);
            this.labelCustomerNumber.TabIndex = 28;
            this.labelCustomerNumber.Text = "Customer Number";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 175);
            this.Controls.Add(this.tbCustomerNumber);
            this.Controls.Add(this.labelCustomerNumber);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.btnPayOut);
            this.Controls.Add(this.btnPayIn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayIn;
        private System.Windows.Forms.Button btnPayOut;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox tbAmount;
        private System.Windows.Forms.MaskedTextBox tbCustomerNumber;
        private System.Windows.Forms.Label labelCustomerNumber;
    }
}