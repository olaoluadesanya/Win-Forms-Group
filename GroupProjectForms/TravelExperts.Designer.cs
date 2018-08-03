namespace GroupProjectForms
{
    partial class TravelExperts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelExperts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tabPackageProductSupplier = new System.Windows.Forms.TabPage();
            this.btnDropPro = new System.Windows.Forms.Button();
            this.btnAddProdtoPack = new System.Windows.Forms.Button();
            this.dgSup = new System.Windows.Forms.DataGridView();
            this.SuppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProd = new System.Windows.Forms.DataGridView();
            this.ProduName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdAddProducts = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrdInPack = new System.Windows.Forms.Label();
            this.dgViewSubPack = new System.Windows.Forms.DataGridView();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPackageProductSuppliers = new System.Windows.Forms.DataGridView();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPackages = new System.Windows.Forms.TabPage();
            this.dgPackages = new System.Windows.Forms.DataGridView();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.dgSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.PackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgAgencyCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMain.SuspendLayout();
            this.tabPackageProductSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSubPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPackageProductSuppliers)).BeginInit();
            this.tabPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPackages)).BeginInit();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(140, 412);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(264, 412);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tabPackageProductSupplier);
            this.tbMain.Controls.Add(this.tabPackages);
            this.tbMain.Controls.Add(this.tabProducts);
            this.tbMain.Controls.Add(this.tabSuppliers);
            this.tbMain.Location = new System.Drawing.Point(13, 13);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(775, 362);
            this.tbMain.TabIndex = 3;
            this.tbMain.SelectedIndexChanged += new System.EventHandler(this.tbMain_SelectedIndexChanged);
            // 
            // tabPackageProductSupplier
            // 
            this.tabPackageProductSupplier.Controls.Add(this.btnDropPro);
            this.tabPackageProductSupplier.Controls.Add(this.btnAddProdtoPack);
            this.tabPackageProductSupplier.Controls.Add(this.dgSup);
            this.tabPackageProductSupplier.Controls.Add(this.dgProd);
            this.tabPackageProductSupplier.Controls.Add(this.rdAddProducts);
            this.tabPackageProductSupplier.Controls.Add(this.label2);
            this.tabPackageProductSupplier.Controls.Add(this.label1);
            this.tabPackageProductSupplier.Controls.Add(this.lblPrdInPack);
            this.tabPackageProductSupplier.Controls.Add(this.dgViewSubPack);
            this.tabPackageProductSupplier.Controls.Add(this.dgPackageProductSuppliers);
            this.tabPackageProductSupplier.Location = new System.Drawing.Point(4, 22);
            this.tabPackageProductSupplier.Name = "tabPackageProductSupplier";
            this.tabPackageProductSupplier.Size = new System.Drawing.Size(767, 336);
            this.tabPackageProductSupplier.TabIndex = 4;
            this.tabPackageProductSupplier.Text = "Home";
            this.tabPackageProductSupplier.UseVisualStyleBackColor = true;
            // 
            // btnDropPro
            // 
            this.btnDropPro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDropPro.BackgroundImage")));
            this.btnDropPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDropPro.Location = new System.Drawing.Point(446, 180);
            this.btnDropPro.Name = "btnDropPro";
            this.btnDropPro.Size = new System.Drawing.Size(33, 23);
            this.btnDropPro.TabIndex = 12;
            this.btnDropPro.UseVisualStyleBackColor = true;
            this.btnDropPro.Click += new System.EventHandler(this.btnDropPro_Click);
            // 
            // btnAddProdtoPack
            // 
            this.btnAddProdtoPack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProdtoPack.BackgroundImage")));
            this.btnAddProdtoPack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddProdtoPack.Location = new System.Drawing.Point(446, 150);
            this.btnAddProdtoPack.Name = "btnAddProdtoPack";
            this.btnAddProdtoPack.Size = new System.Drawing.Size(33, 23);
            this.btnAddProdtoPack.TabIndex = 11;
            this.btnAddProdtoPack.UseVisualStyleBackColor = true;
            this.btnAddProdtoPack.Click += new System.EventHandler(this.btnAddProdtoPack_Click);
            // 
            // dgSup
            // 
            this.dgSup.AllowUserToAddRows = false;
            this.dgSup.AllowUserToDeleteRows = false;
            this.dgSup.AllowUserToResizeRows = false;
            this.dgSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SuppName});
            this.dgSup.Location = new System.Drawing.Point(609, 26);
            this.dgSup.MultiSelect = false;
            this.dgSup.Name = "dgSup";
            this.dgSup.RowHeadersVisible = false;
            this.dgSup.ShowEditingIcon = false;
            this.dgSup.Size = new System.Drawing.Size(155, 265);
            this.dgSup.TabIndex = 9;
            // 
            // SuppName
            // 
            this.SuppName.DataPropertyName = "SupName";
            this.SuppName.HeaderText = "Supplier";
            this.SuppName.Name = "SuppName";
            this.SuppName.ReadOnly = true;
            // 
            // dgProd
            // 
            this.dgProd.AllowUserToAddRows = false;
            this.dgProd.AllowUserToResizeRows = false;
            this.dgProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProduName});
            this.dgProd.Location = new System.Drawing.Point(485, 26);
            this.dgProd.MultiSelect = false;
            this.dgProd.Name = "dgProd";
            this.dgProd.RowHeadersVisible = false;
            this.dgProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProd.Size = new System.Drawing.Size(118, 265);
            this.dgProd.TabIndex = 8;
            this.dgProd.SelectionChanged += new System.EventHandler(this.dgProd_SelectionChanged);
            // 
            // ProduName
            // 
            this.ProduName.DataPropertyName = "ProdName";
            this.ProduName.HeaderText = "Product Name";
            this.ProduName.Name = "ProduName";
            this.ProduName.ReadOnly = true;
            // 
            // rdAddProducts
            // 
            this.rdAddProducts.AutoSize = true;
            this.rdAddProducts.Location = new System.Drawing.Point(485, 297);
            this.rdAddProducts.Name = "rdAddProducts";
            this.rdAddProducts.Size = new System.Drawing.Size(162, 17);
            this.rdAddProducts.TabIndex = 7;
            this.rdAddProducts.TabStop = true;
            this.rdAddProducts.Text = "Add a new Product/ Supplier";
            this.rdAddProducts.UseVisualStyleBackColor = true;
            this.rdAddProducts.CheckedChanged += new System.EventHandler(this.rdAddProducts_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select from existing Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Packages";
            // 
            // lblPrdInPack
            // 
            this.lblPrdInPack.AutoSize = true;
            this.lblPrdInPack.Location = new System.Drawing.Point(167, 10);
            this.lblPrdInPack.Name = "lblPrdInPack";
            this.lblPrdInPack.Size = new System.Drawing.Size(150, 13);
            this.lblPrdInPack.TabIndex = 3;
            this.lblPrdInPack.Text = "Products Currently in Package";
            // 
            // dgViewSubPack
            // 
            this.dgViewSubPack.AllowUserToAddRows = false;
            this.dgViewSubPack.AllowUserToDeleteRows = false;
            this.dgViewSubPack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgViewSubPack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSubPack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdName,
            this.SupName});
            this.dgViewSubPack.Location = new System.Drawing.Point(170, 26);
            this.dgViewSubPack.MultiSelect = false;
            this.dgViewSubPack.Name = "dgViewSubPack";
            this.dgViewSubPack.ReadOnly = true;
            this.dgViewSubPack.RowHeadersVisible = false;
            this.dgViewSubPack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewSubPack.Size = new System.Drawing.Size(269, 304);
            this.dgViewSubPack.TabIndex = 2;
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Product Name";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // SupName
            // 
            this.SupName.DataPropertyName = "SupName";
            this.SupName.FillWeight = 158.7629F;
            this.SupName.HeaderText = "Supplier Name";
            this.SupName.Name = "SupName";
            this.SupName.ReadOnly = true;
            // 
            // dgPackageProductSuppliers
            // 
            this.dgPackageProductSuppliers.AllowUserToAddRows = false;
            this.dgPackageProductSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPackageProductSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPackageProductSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageName});
            this.dgPackageProductSuppliers.Location = new System.Drawing.Point(6, 26);
            this.dgPackageProductSuppliers.MultiSelect = false;
            this.dgPackageProductSuppliers.Name = "dgPackageProductSuppliers";
            this.dgPackageProductSuppliers.ReadOnly = true;
            this.dgPackageProductSuppliers.RowHeadersVisible = false;
            this.dgPackageProductSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPackageProductSuppliers.Size = new System.Drawing.Size(158, 304);
            this.dgPackageProductSuppliers.TabIndex = 1;
            this.dgPackageProductSuppliers.SelectionChanged += new System.EventHandler(this.dgPackageProductSuppliers_SelectionChanged);
            // 
            // PackageName
            // 
            this.PackageName.DataPropertyName = "Name";
            this.PackageName.HeaderText = "Package Name";
            this.PackageName.Name = "PackageName";
            this.PackageName.ReadOnly = true;
            // 
            // tabPackages
            // 
            this.tabPackages.Controls.Add(this.dgPackages);
            this.tabPackages.Location = new System.Drawing.Point(4, 22);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPackages.Size = new System.Drawing.Size(767, 336);
            this.tabPackages.TabIndex = 0;
            this.tabPackages.Text = "Packages";
            this.tabPackages.UseVisualStyleBackColor = true;
            // 
            // dgPackages
            // 
            this.dgPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageId,
            this.PkgName,
            this.PkgStartDate,
            this.PkgEndDate,
            this.PkgDesc,
            this.PkgBasePrice,
            this.PkgAgencyCommission});
            this.dgPackages.Location = new System.Drawing.Point(7, 7);
            this.dgPackages.MultiSelect = false;
            this.dgPackages.Name = "dgPackages";
            this.dgPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPackages.Size = new System.Drawing.Size(754, 323);
            this.dgPackages.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.dgProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(767, 336);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // dgProducts
            // 
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.dataGridViewTextBoxColumn2});
            this.dgProducts.Location = new System.Drawing.Point(6, 7);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(219, 323);
            this.dgProducts.TabIndex = 1;
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ID";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.dgSuppliers);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(767, 336);
            this.tabSuppliers.TabIndex = 2;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // dgSuppliers
            // 
            this.dgSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.dataGridViewTextBoxColumn1});
            this.dgSuppliers.Location = new System.Drawing.Point(6, 7);
            this.dgSuppliers.MultiSelect = false;
            this.dgSuppliers.Name = "dgSuppliers";
            this.dgSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSuppliers.Size = new System.Drawing.Size(286, 323);
            this.dgSuppliers.TabIndex = 1;
            // 
            // SupplierId
            // 
            this.SupplierId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "ID";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            this.SupplierId.Width = 43;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(709, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PackageId
            // 
            this.PackageId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PackageId.DataPropertyName = "PackageId";
            this.PackageId.HeaderText = "ID";
            this.PackageId.Name = "PackageId";
            this.PackageId.ReadOnly = true;
            this.PackageId.Width = 43;
            // 
            // PkgName
            // 
            this.PkgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PkgName.DataPropertyName = "Name";
            this.PkgName.HeaderText = "Name";
            this.PkgName.Name = "PkgName";
            this.PkgName.ReadOnly = true;
            this.PkgName.Width = 60;
            // 
            // PkgStartDate
            // 
            this.PkgStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PkgStartDate.DataPropertyName = "StartDate";
            this.PkgStartDate.HeaderText = "Start Date";
            this.PkgStartDate.Name = "PkgStartDate";
            this.PkgStartDate.ReadOnly = true;
            this.PkgStartDate.Width = 80;
            // 
            // PkgEndDate
            // 
            this.PkgEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PkgEndDate.DataPropertyName = "EndDate";
            this.PkgEndDate.HeaderText = "End Date";
            this.PkgEndDate.Name = "PkgEndDate";
            this.PkgEndDate.ReadOnly = true;
            this.PkgEndDate.Width = 77;
            // 
            // PkgDesc
            // 
            this.PkgDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PkgDesc.DataPropertyName = "Desc";
            this.PkgDesc.HeaderText = "Desciption";
            this.PkgDesc.Name = "PkgDesc";
            this.PkgDesc.ReadOnly = true;
            // 
            // PkgBasePrice
            // 
            this.PkgBasePrice.DataPropertyName = "BasePrice";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.PkgBasePrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.PkgBasePrice.HeaderText = "Base Price";
            this.PkgBasePrice.Name = "PkgBasePrice";
            this.PkgBasePrice.ReadOnly = true;
            // 
            // PkgAgencyCommission
            // 
            this.PkgAgencyCommission.DataPropertyName = "AgencyCommission";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.PkgAgencyCommission.DefaultCellStyle = dataGridViewCellStyle4;
            this.PkgAgencyCommission.HeaderText = "Agency Commission";
            this.PkgAgencyCommission.Name = "PkgAgencyCommission";
            this.PkgAgencyCommission.ReadOnly = true;
            // 
            // TravelExperts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "TravelExperts";
            this.Text = "TravelExperts";
            this.Load += new System.EventHandler(this.TravelExperts_Load);
            this.tbMain.ResumeLayout(false);
            this.tabPackageProductSupplier.ResumeLayout(false);
            this.tabPackageProductSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSubPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPackageProductSuppliers)).EndInit();
            this.tabPackages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPackages)).EndInit();
            this.tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tabPackages;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tabPackageProductSupplier;
        private System.Windows.Forms.DataGridView dgPackages;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.DataGridView dgSuppliers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgPackageProductSuppliers;
        private System.Windows.Forms.DataGridView dgViewSubPack;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.RadioButton rdAddProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrdInPack;
        private System.Windows.Forms.DataGridView dgProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduName;
        private System.Windows.Forms.DataGridView dgSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppName;
        private System.Windows.Forms.Button btnAddProdtoPack;
        private System.Windows.Forms.Button btnDropPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgAgencyCommission;
    }
}