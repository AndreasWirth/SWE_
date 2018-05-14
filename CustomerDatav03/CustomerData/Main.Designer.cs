namespace CustomerData
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btOpenAddCustomer = new System.Windows.Forms.Button();
            this.btnOpenBooking = new System.Windows.Forms.Button();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.btnOpenChangeCustomer = new System.Windows.Forms.Button();
            this.lbCustomer = new System.Windows.Forms.ListBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.gBFilterBy = new System.Windows.Forms.GroupBox();
            this.tbFilterby = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gBFilterBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOpenAddCustomer
            // 
            this.btOpenAddCustomer.Location = new System.Drawing.Point(47, 42);
            this.btOpenAddCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOpenAddCustomer.Name = "btOpenAddCustomer";
            this.btOpenAddCustomer.Size = new System.Drawing.Size(176, 36);
            this.btOpenAddCustomer.TabIndex = 0;
            this.btOpenAddCustomer.Text = "Add Customer";
            this.btOpenAddCustomer.UseVisualStyleBackColor = true;
            this.btOpenAddCustomer.Click += new System.EventHandler(this.btOpenAddCustomer_Click);
            // 
            // btnOpenBooking
            // 
            this.btnOpenBooking.Location = new System.Drawing.Point(506, 42);
            this.btnOpenBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenBooking.Name = "btnOpenBooking";
            this.btnOpenBooking.Size = new System.Drawing.Size(176, 36);
            this.btnOpenBooking.TabIndex = 1;
            this.btnOpenBooking.Text = "Make Booking";
            this.btnOpenBooking.UseVisualStyleBackColor = true;
            this.btnOpenBooking.Click += new System.EventHandler(this.btnOpenBooking_Click);
            // 
            // btnShowCustomer
            // 
            this.btnShowCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowCustomer.Location = new System.Drawing.Point(506, 153);
            this.btnShowCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowCustomer.Name = "btnShowCustomer";
            this.btnShowCustomer.Size = new System.Drawing.Size(176, 36);
            this.btnShowCustomer.TabIndex = 2;
            this.btnShowCustomer.Text = "add test Customers";
            this.btnShowCustomer.UseVisualStyleBackColor = false;
            this.btnShowCustomer.Click += new System.EventHandler(this.btnShowCustomer_Click);
            // 
            // btnOpenChangeCustomer
            // 
            this.btnOpenChangeCustomer.Location = new System.Drawing.Point(282, 42);
            this.btnOpenChangeCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenChangeCustomer.Name = "btnOpenChangeCustomer";
            this.btnOpenChangeCustomer.Size = new System.Drawing.Size(176, 36);
            this.btnOpenChangeCustomer.TabIndex = 3;
            this.btnOpenChangeCustomer.Text = "Change Customer";
            this.btnOpenChangeCustomer.UseVisualStyleBackColor = true;
            this.btnOpenChangeCustomer.Click += new System.EventHandler(this.btnOpenChangeCustomer_Click);
            // 
            // lbCustomer
            // 
            this.lbCustomer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.FormattingEnabled = true;
            this.lbCustomer.ItemHeight = 18;
            this.lbCustomer.Location = new System.Drawing.Point(47, 218);
            this.lbCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(901, 148);
            this.lbCustomer.TabIndex = 5;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(47, 423);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(176, 36);
            this.btnSaveData.TabIndex = 7;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(291, 423);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(176, 36);
            this.btnLoadData.TabIndex = 8;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbName);
            this.groupBox1.Controls.Add(this.rbID);
            this.groupBox1.Location = new System.Drawing.Point(47, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(177, 80);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(17, 44);
            this.rbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(97, 21);
            this.rbName.TabIndex = 1;
            this.rbName.TabStop = true;
            this.rbName.Text = "Last Name";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(16, 21);
            this.rbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(42, 21);
            this.rbID.TabIndex = 0;
            this.rbID.TabStop = true;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // gBFilterBy
            // 
            this.gBFilterBy.Controls.Add(this.tbFilterby);
            this.gBFilterBy.Location = new System.Drawing.Point(282, 132);
            this.gBFilterBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBFilterBy.Name = "gBFilterBy";
            this.gBFilterBy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBFilterBy.Size = new System.Drawing.Size(177, 80);
            this.gBFilterBy.TabIndex = 29;
            this.gBFilterBy.TabStop = false;
            this.gBFilterBy.Text = "Filter By:";
            // 
            // tbFilterby
            // 
            this.tbFilterby.Location = new System.Drawing.Point(16, 34);
            this.tbFilterby.MaxLength = 10;
            this.tbFilterby.Name = "tbFilterby";
            this.tbFilterby.Size = new System.Drawing.Size(142, 22);
            this.tbFilterby.TabIndex = 0;
            this.tbFilterby.TextChanged += new System.EventHandler(this.tbFilterby_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 489);
            this.Controls.Add(this.gBFilterBy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.btnOpenChangeCustomer);
            this.Controls.Add(this.btnShowCustomer);
            this.Controls.Add(this.btnOpenBooking);
            this.Controls.Add(this.btOpenAddCustomer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBFilterBy.ResumeLayout(false);
            this.gBFilterBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpenAddCustomer;
        private System.Windows.Forms.Button btnOpenBooking;
        private System.Windows.Forms.Button btnShowCustomer;
        private System.Windows.Forms.Button btnOpenChangeCustomer;
        private System.Windows.Forms.ListBox lbCustomer;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.GroupBox gBFilterBy;
        private System.Windows.Forms.TextBox tbFilterby;
    }
}

