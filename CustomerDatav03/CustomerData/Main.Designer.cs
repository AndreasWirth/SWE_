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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btOpenAddCustomer = new System.Windows.Forms.Button();
            this.btnOpenBooking = new System.Windows.Forms.Button();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.btnOpenChangeCustomer = new System.Windows.Forms.Button();
            this.lbCustomer = new System.Windows.Forms.ListBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.gbSortby = new System.Windows.Forms.GroupBox();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.gBFilterBy = new System.Windows.Forms.GroupBox();
            this.tbFilterby = new System.Windows.Forms.TextBox();
            this.myData = new CustomerData.MyData();
            this.btnChangeLanguage = new System.Windows.Forms.Button();
            this.gbSortby.SuspendLayout();
            this.gBFilterBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myData)).BeginInit();
            this.SuspendLayout();
            // 
            // btOpenAddCustomer
            // 
            resources.ApplyResources(this.btOpenAddCustomer, "btOpenAddCustomer");
            this.btOpenAddCustomer.Name = "btOpenAddCustomer";
            this.btOpenAddCustomer.UseVisualStyleBackColor = true;
            this.btOpenAddCustomer.Click += new System.EventHandler(this.btOpenAddCustomer_Click);
            // 
            // btnOpenBooking
            // 
            resources.ApplyResources(this.btnOpenBooking, "btnOpenBooking");
            this.btnOpenBooking.Name = "btnOpenBooking";
            this.btnOpenBooking.UseVisualStyleBackColor = true;
            this.btnOpenBooking.Click += new System.EventHandler(this.btnOpenBooking_Click);
            // 
            // btnShowCustomer
            // 
            this.btnShowCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnShowCustomer, "btnShowCustomer");
            this.btnShowCustomer.Name = "btnShowCustomer";
            this.btnShowCustomer.UseVisualStyleBackColor = false;
            this.btnShowCustomer.Click += new System.EventHandler(this.btnShowCustomer_Click);
            // 
            // btnOpenChangeCustomer
            // 
            resources.ApplyResources(this.btnOpenChangeCustomer, "btnOpenChangeCustomer");
            this.btnOpenChangeCustomer.Name = "btnOpenChangeCustomer";
            this.btnOpenChangeCustomer.UseVisualStyleBackColor = true;
            this.btnOpenChangeCustomer.Click += new System.EventHandler(this.btnOpenChangeCustomer_Click);
            // 
            // lbCustomer
            // 
            resources.ApplyResources(this.lbCustomer, "lbCustomer");
            this.lbCustomer.FormattingEnabled = true;
            this.lbCustomer.Name = "lbCustomer";
            // 
            // btnSaveData
            // 
            resources.ApplyResources(this.btnSaveData, "btnSaveData");
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnLoadData
            // 
            resources.ApplyResources(this.btnLoadData, "btnLoadData");
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // gbSortby
            // 
            this.gbSortby.Controls.Add(this.rbName);
            this.gbSortby.Controls.Add(this.rbID);
            resources.ApplyResources(this.gbSortby, "gbSortby");
            this.gbSortby.Name = "gbSortby";
            this.gbSortby.TabStop = false;
            this.gbSortby.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbName
            // 
            resources.ApplyResources(this.rbName, "rbName");
            this.rbName.Name = "rbName";
            this.rbName.TabStop = true;
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged_1);
            // 
            // rbID
            // 
            resources.ApplyResources(this.rbID, "rbID");
            this.rbID.Name = "rbID";
            this.rbID.TabStop = true;
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged_1);
            // 
            // gBFilterBy
            // 
            this.gBFilterBy.Controls.Add(this.tbFilterby);
            resources.ApplyResources(this.gBFilterBy, "gBFilterBy");
            this.gBFilterBy.Name = "gBFilterBy";
            this.gBFilterBy.TabStop = false;
            // 
            // tbFilterby
            // 
            resources.ApplyResources(this.tbFilterby, "tbFilterby");
            this.tbFilterby.Name = "tbFilterby";
            this.tbFilterby.TextChanged += new System.EventHandler(this.tbFilterby_TextChanged_1);
            // 
            // myData
            // 
            this.myData.DataSetName = "MyData";
            this.myData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnChangeLanguage
            // 
            resources.ApplyResources(this.btnChangeLanguage, "btnChangeLanguage");
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.UseVisualStyleBackColor = true;
            this.btnChangeLanguage.Click += new System.EventHandler(this.btnChangeLanguage_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangeLanguage);
            this.Controls.Add(this.gBFilterBy);
            this.Controls.Add(this.gbSortby);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.btnOpenChangeCustomer);
            this.Controls.Add(this.btnShowCustomer);
            this.Controls.Add(this.btnOpenBooking);
            this.Controls.Add(this.btOpenAddCustomer);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbSortby.ResumeLayout(false);
            this.gbSortby.PerformLayout();
            this.gBFilterBy.ResumeLayout(false);
            this.gBFilterBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myData)).EndInit();
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
        private System.Windows.Forms.GroupBox gbSortby;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.GroupBox gBFilterBy;
        private System.Windows.Forms.TextBox tbFilterby;
        private MyData myData;
        private System.Windows.Forms.Button btnChangeLanguage;
    }
}

