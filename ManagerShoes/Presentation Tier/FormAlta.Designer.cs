namespace Presentation_Tier
{
    partial class FormAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlta));
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelPruductProvider = new System.Windows.Forms.Label();
            this.labelProductImage = new System.Windows.Forms.Label();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBoxProductColors = new System.Windows.Forms.ListBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(32, 37);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(158, 20);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Nombre del Producto";
            this.labelProductName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPruductProvider
            // 
            this.labelPruductProvider.AutoSize = true;
            this.labelPruductProvider.Location = new System.Drawing.Point(32, 86);
            this.labelPruductProvider.Name = "labelPruductProvider";
            this.labelPruductProvider.Size = new System.Drawing.Size(174, 20);
            this.labelPruductProvider.TabIndex = 0;
            this.labelPruductProvider.Text = "Proveedor del Producto";
            this.labelPruductProvider.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelProductImage
            // 
            this.labelProductImage.AutoSize = true;
            this.labelProductImage.Location = new System.Drawing.Point(34, 136);
            this.labelProductImage.Name = "labelProductImage";
            this.labelProductImage.Size = new System.Drawing.Size(156, 20);
            this.labelProductImage.TabIndex = 0;
            this.labelProductImage.Text = "Imagen del Producto";
            this.labelProductImage.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(212, 130);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(129, 33);
            this.btnSearchFile.TabIndex = 2;
            this.btnSearchFile.Text = "Subir Archivo";
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(492, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(279, 286);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(212, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(241, 34);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listBoxProductColors
            // 
            this.listBoxProductColors.FormattingEnabled = true;
            this.listBoxProductColors.ItemHeight = 20;
            this.listBoxProductColors.Location = new System.Drawing.Point(212, 185);
            this.listBoxProductColors.Name = "listBoxProductColors";
            this.listBoxProductColors.Size = new System.Drawing.Size(266, 24);
            this.listBoxProductColors.TabIndex = 6;
            this.listBoxProductColors.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(438, 359);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(154, 49);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Agregar";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.listBoxProductColors);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnSearchFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProductImage);
            this.Controls.Add(this.labelPruductProvider);
            this.Controls.Add(this.labelProductName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelPruductProvider;
        private System.Windows.Forms.Label labelProductImage;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBoxProductColors;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
    }
}