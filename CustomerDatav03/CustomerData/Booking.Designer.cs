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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.MaskedTextBox();
            this.tbCustomerNumber = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Customer Number";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 175);
            this.Controls.Add(this.tbCustomerNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox tbAmount;
        private System.Windows.Forms.MaskedTextBox tbCustomerNumber;
        private System.Windows.Forms.Label label6;
    }
}