namespace CustomerData
{
    partial class FillLanguageDAtaset
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.germanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myData = new CustomerData.MyData();
            this.btnStorelanguage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyDataGridViewTextBoxColumn,
            this.englishDataGridViewTextBoxColumn,
            this.germanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.speachBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 345);
            this.dataGridView1.TabIndex = 33;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "key";
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            // 
            // englishDataGridViewTextBoxColumn
            // 
            this.englishDataGridViewTextBoxColumn.DataPropertyName = "English";
            this.englishDataGridViewTextBoxColumn.HeaderText = "English";
            this.englishDataGridViewTextBoxColumn.Name = "englishDataGridViewTextBoxColumn";
            // 
            // germanDataGridViewTextBoxColumn
            // 
            this.germanDataGridViewTextBoxColumn.DataPropertyName = "German";
            this.germanDataGridViewTextBoxColumn.HeaderText = "German";
            this.germanDataGridViewTextBoxColumn.Name = "germanDataGridViewTextBoxColumn";
            // 
            // speachBindingSource
            // 
            this.speachBindingSource.DataMember = "speach";
            this.speachBindingSource.DataSource = this.myData;
            // 
            // myData
            // 
            this.myData.DataSetName = "MyData";
            this.myData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnStorelanguage
            // 
            this.btnStorelanguage.Location = new System.Drawing.Point(57, 12);
            this.btnStorelanguage.Name = "btnStorelanguage";
            this.btnStorelanguage.Size = new System.Drawing.Size(75, 23);
            this.btnStorelanguage.TabIndex = 32;
            this.btnStorelanguage.Text = "Store";
            this.btnStorelanguage.UseVisualStyleBackColor = true;
            this.btnStorelanguage.Click += new System.EventHandler(this.btnStorelanguage_Click);
            // 
            // FillLanguageDAtaset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStorelanguage);
            this.Name = "FillLanguageDAtaset";
            this.Text = "FillLanguageDAtaset";
            this.Load += new System.EventHandler(this.FillLanguageDAtaset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStorelanguage;
        private System.Windows.Forms.BindingSource speachBindingSource;
        private MyData myData;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn germanDataGridViewTextBoxColumn;
    }
}