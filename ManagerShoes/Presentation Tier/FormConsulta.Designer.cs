namespace Presentation_Tier
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProdId = new System.Windows.Forms.TextBox();
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCatalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDistributorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEnabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(477, 102);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(116, 47);
            this.btnSearchProduct.TabIndex = 0;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(60, 155);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(116, 20);
            this.labelProductId.TabIndex = 2;
            this.labelProductId.Text = "Id del Producto";
            this.labelProductId.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(60, 203);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(158, 20);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Nombre del Producto";
            this.labelProductName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxProdId
            // 
            this.textBoxProdId.Location = new System.Drawing.Point(245, 155);
            this.textBoxProdId.Name = "textBoxProdId";
            this.textBoxProdId.Size = new System.Drawing.Size(154, 26);
            this.textBoxProdId.TabIndex = 1;
            this.textBoxProdId.TextChanged += new System.EventHandler(this.textBoxProdId_TextChanged);
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(245, 200);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(154, 26);
            this.textBoxProdName.TabIndex = 1;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(477, 155);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(116, 50);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProd);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(477, 211);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(116, 50);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idTypeDataGridViewTextBoxColumn,
            this.idColorDataGridViewTextBoxColumn,
            this.idBrandDataGridViewTextBoxColumn,
            this.idProviderDataGridViewTextBoxColumn,
            this.idCatalogDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.observationsDataGridViewTextBoxColumn,
            this.priceDistributorDataGridViewTextBoxColumn,
            this.priceClientDataGridViewTextBoxColumn,
            this.priceMemberDataGridViewTextBoxColumn,
            this.isEnabledDataGridViewCheckBoxColumn,
            this.keywordsDataGridViewTextBoxColumn,
            this.dateUpdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productEntityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(937, 278);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idTypeDataGridViewTextBoxColumn
            // 
            this.idTypeDataGridViewTextBoxColumn.DataPropertyName = "IdType";
            this.idTypeDataGridViewTextBoxColumn.HeaderText = "IdType";
            this.idTypeDataGridViewTextBoxColumn.Name = "idTypeDataGridViewTextBoxColumn";
            // 
            // idColorDataGridViewTextBoxColumn
            // 
            this.idColorDataGridViewTextBoxColumn.DataPropertyName = "IdColor";
            this.idColorDataGridViewTextBoxColumn.HeaderText = "IdColor";
            this.idColorDataGridViewTextBoxColumn.Name = "idColorDataGridViewTextBoxColumn";
            // 
            // idBrandDataGridViewTextBoxColumn
            // 
            this.idBrandDataGridViewTextBoxColumn.DataPropertyName = "IdBrand";
            this.idBrandDataGridViewTextBoxColumn.HeaderText = "IdBrand";
            this.idBrandDataGridViewTextBoxColumn.Name = "idBrandDataGridViewTextBoxColumn";
            // 
            // idProviderDataGridViewTextBoxColumn
            // 
            this.idProviderDataGridViewTextBoxColumn.DataPropertyName = "IdProvider";
            this.idProviderDataGridViewTextBoxColumn.HeaderText = "IdProvider";
            this.idProviderDataGridViewTextBoxColumn.Name = "idProviderDataGridViewTextBoxColumn";
            // 
            // idCatalogDataGridViewTextBoxColumn
            // 
            this.idCatalogDataGridViewTextBoxColumn.DataPropertyName = "IdCatalog";
            this.idCatalogDataGridViewTextBoxColumn.HeaderText = "IdCatalog";
            this.idCatalogDataGridViewTextBoxColumn.Name = "idCatalogDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // observationsDataGridViewTextBoxColumn
            // 
            this.observationsDataGridViewTextBoxColumn.DataPropertyName = "Observations";
            this.observationsDataGridViewTextBoxColumn.HeaderText = "Observations";
            this.observationsDataGridViewTextBoxColumn.Name = "observationsDataGridViewTextBoxColumn";
            // 
            // priceDistributorDataGridViewTextBoxColumn
            // 
            this.priceDistributorDataGridViewTextBoxColumn.DataPropertyName = "PriceDistributor";
            this.priceDistributorDataGridViewTextBoxColumn.HeaderText = "PriceDistributor";
            this.priceDistributorDataGridViewTextBoxColumn.Name = "priceDistributorDataGridViewTextBoxColumn";
            // 
            // priceClientDataGridViewTextBoxColumn
            // 
            this.priceClientDataGridViewTextBoxColumn.DataPropertyName = "PriceClient";
            this.priceClientDataGridViewTextBoxColumn.HeaderText = "PriceClient";
            this.priceClientDataGridViewTextBoxColumn.Name = "priceClientDataGridViewTextBoxColumn";
            // 
            // priceMemberDataGridViewTextBoxColumn
            // 
            this.priceMemberDataGridViewTextBoxColumn.DataPropertyName = "PriceMember";
            this.priceMemberDataGridViewTextBoxColumn.HeaderText = "PriceMember";
            this.priceMemberDataGridViewTextBoxColumn.Name = "priceMemberDataGridViewTextBoxColumn";
            // 
            // isEnabledDataGridViewCheckBoxColumn
            // 
            this.isEnabledDataGridViewCheckBoxColumn.DataPropertyName = "IsEnabled";
            this.isEnabledDataGridViewCheckBoxColumn.HeaderText = "IsEnabled";
            this.isEnabledDataGridViewCheckBoxColumn.Name = "isEnabledDataGridViewCheckBoxColumn";
            // 
            // keywordsDataGridViewTextBoxColumn
            // 
            this.keywordsDataGridViewTextBoxColumn.DataPropertyName = "Keywords";
            this.keywordsDataGridViewTextBoxColumn.HeaderText = "Keywords";
            this.keywordsDataGridViewTextBoxColumn.Name = "keywordsDataGridViewTextBoxColumn";
            // 
            // dateUpdateDataGridViewTextBoxColumn
            // 
            this.dateUpdateDataGridViewTextBoxColumn.DataPropertyName = "DateUpdate";
            this.dateUpdateDataGridViewTextBoxColumn.HeaderText = "DateUpdate";
            this.dateUpdateDataGridViewTextBoxColumn.Name = "dateUpdateDataGridViewTextBoxColumn";
            // 
            // productEntityBindingSource
            // 
            this.productEntityBindingSource.DataSource = typeof(Entity_Tier.ProductEntity);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 615);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.textBoxProdName);
            this.Controls.Add(this.textBoxProdId);
            this.Controls.Add(this.btnSearchProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsulta";
            this.Text = "Cunsultar";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProdId;
        private System.Windows.Forms.TextBox textBoxProdName;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCatalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDistributorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEnabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productEntityBindingSource;
    }
}

