namespace GroupProjectForms
{
    partial class Form1
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
            this.tbMain = new System.Windows.Forms.TabControl();
            this.Packages = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.packageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyCommissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Products = new System.Windows.Forms.TabPage();
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.Product_Supplier = new System.Windows.Forms.TabPage();
            this.Package_Product_Supplier = new System.Windows.Forms.TabPage();
            this.tbMain.SuspendLayout();
            this.Packages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.Packages);
            this.tbMain.Controls.Add(this.Products);
            this.tbMain.Controls.Add(this.Suppliers);
            this.tbMain.Controls.Add(this.Product_Supplier);
            this.tbMain.Controls.Add(this.Package_Product_Supplier);
            this.tbMain.Location = new System.Drawing.Point(12, 12);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(776, 378);
            this.tbMain.TabIndex = 0;
            // 
            // Packages
            // 
            this.Packages.Controls.Add(this.dataGridView1);
            this.Packages.Location = new System.Drawing.Point(4, 22);
            this.Packages.Name = "Packages";
            this.Packages.Size = new System.Drawing.Size(768, 352);
            this.Packages.TabIndex = 2;
            this.Packages.Text = "Packages";
            this.Packages.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packageIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn,
            this.basePriceDataGridViewTextBoxColumn,
            this.agencyCommissionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.packageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // packageIdDataGridViewTextBoxColumn
            // 
            this.packageIdDataGridViewTextBoxColumn.DataPropertyName = "PackageId";
            this.packageIdDataGridViewTextBoxColumn.HeaderText = "PackageId";
            this.packageIdDataGridViewTextBoxColumn.Name = "packageIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "Desc";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            // 
            // basePriceDataGridViewTextBoxColumn
            // 
            this.basePriceDataGridViewTextBoxColumn.DataPropertyName = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.HeaderText = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            // 
            // agencyCommissionDataGridViewTextBoxColumn
            // 
            this.agencyCommissionDataGridViewTextBoxColumn.DataPropertyName = "AgencyCommission";
            this.agencyCommissionDataGridViewTextBoxColumn.HeaderText = "AgencyCommission";
            this.agencyCommissionDataGridViewTextBoxColumn.Name = "agencyCommissionDataGridViewTextBoxColumn";
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(GroupProjectForms.Models.Package);
            // 
            // Products
            // 
            this.Products.Location = new System.Drawing.Point(4, 22);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(768, 400);
            this.Products.TabIndex = 1;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // Suppliers
            // 
            this.Suppliers.Location = new System.Drawing.Point(4, 22);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Padding = new System.Windows.Forms.Padding(3);
            this.Suppliers.Size = new System.Drawing.Size(768, 400);
            this.Suppliers.TabIndex = 0;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.UseVisualStyleBackColor = true;
            // 
            // Product_Supplier
            // 
            this.Product_Supplier.Location = new System.Drawing.Point(4, 22);
            this.Product_Supplier.Name = "Product_Supplier";
            this.Product_Supplier.Size = new System.Drawing.Size(768, 400);
            this.Product_Supplier.TabIndex = 3;
            this.Product_Supplier.Text = "Product Supplier";
            this.Product_Supplier.UseVisualStyleBackColor = true;
            // 
            // Package_Product_Supplier
            // 
            this.Package_Product_Supplier.Location = new System.Drawing.Point(4, 22);
            this.Package_Product_Supplier.Name = "Package_Product_Supplier";
            this.Package_Product_Supplier.Size = new System.Drawing.Size(768, 400);
            this.Package_Product_Supplier.TabIndex = 4;
            this.Package_Product_Supplier.Text = "Package Product Suppliers";
            this.Package_Product_Supplier.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbMain.ResumeLayout(false);
            this.Packages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage Suppliers;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Packages;
        private System.Windows.Forms.TabPage Product_Supplier;
        private System.Windows.Forms.TabPage Package_Product_Supplier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyCommissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource packageBindingSource;
    }
}

