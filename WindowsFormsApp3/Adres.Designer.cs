namespace WindowsFormsApp3
{
    partial class Adres
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
            this.treining1DataSet = new WindowsFormsApp3.Treining1DataSet();
            this.adressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adressesTableAdapter = new WindowsFormsApp3.Treining1DataSetTableAdapters.AdressesTableAdapter();
            this.idAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treining1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAdresDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adressesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 459);
            this.dataGridView1.TabIndex = 0;
            // 
            // treining1DataSet
            // 
            this.treining1DataSet.DataSetName = "Treining1DataSet";
            this.treining1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adressesBindingSource
            // 
            this.adressesBindingSource.DataMember = "Adresses";
            this.adressesBindingSource.DataSource = this.treining1DataSet;
            // 
            // adressesTableAdapter
            // 
            this.adressesTableAdapter.ClearBeforeFill = true;
            // 
            // idAdresDataGridViewTextBoxColumn
            // 
            this.idAdresDataGridViewTextBoxColumn.DataPropertyName = "idAdres";
            this.idAdresDataGridViewTextBoxColumn.HeaderText = "idAdres";
            this.idAdresDataGridViewTextBoxColumn.Name = "idAdresDataGridViewTextBoxColumn";
            this.idAdresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // Adres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 501);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Adres";
            this.Text = "Adres";
            this.Load += new System.EventHandler(this.Adres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treining1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Treining1DataSet treining1DataSet;
        private System.Windows.Forms.BindingSource adressesBindingSource;
        private Treining1DataSetTableAdapters.AdressesTableAdapter adressesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
    }
}