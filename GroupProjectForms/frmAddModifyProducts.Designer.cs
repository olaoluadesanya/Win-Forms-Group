namespace GroupProjectForms
{
    partial class frmAddModifyProducts
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
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblSelProd = new System.Windows.Forms.Label();
            this.rdSelectSupFroPro = new System.Windows.Forms.RadioButton();
            this.rdAddSuppfromPro = new System.Windows.Forms.RadioButton();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbSelectProd = new System.Windows.Forms.ComboBox();
            this.rdAddNewProd = new System.Windows.Forms.RadioButton();
            this.rdSelectProd = new System.Windows.Forms.RadioButton();
            this.lblAddProd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(112, 107);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(191, 21);
            this.cmbSuppliers.TabIndex = 0;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(12, 112);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblSelProd
            // 
            this.lblSelProd.AutoSize = true;
            this.lblSelProd.Location = new System.Drawing.Point(12, 29);
            this.lblSelProd.Name = "lblSelProd";
            this.lblSelProd.Size = new System.Drawing.Size(75, 13);
            this.lblSelProd.TabIndex = 2;
            this.lblSelProd.Text = "Product Name";
            // 
            // rdSelectSupFroPro
            // 
            this.rdSelectSupFroPro.AutoSize = true;
            this.rdSelectSupFroPro.Checked = true;
            this.rdSelectSupFroPro.Location = new System.Drawing.Point(329, 108);
            this.rdSelectSupFroPro.Name = "rdSelectSupFroPro";
            this.rdSelectSupFroPro.Size = new System.Drawing.Size(127, 17);
            this.rdSelectSupFroPro.TabIndex = 3;
            this.rdSelectSupFroPro.TabStop = true;
            this.rdSelectSupFroPro.Text = "Select From Suppliers";
            this.rdSelectSupFroPro.UseVisualStyleBackColor = true;
            // 
            // rdAddSuppfromPro
            // 
            this.rdAddSuppfromPro.AutoSize = true;
            this.rdAddSuppfromPro.Location = new System.Drawing.Point(329, 131);
            this.rdAddSuppfromPro.Name = "rdAddSuppfromPro";
            this.rdAddSuppfromPro.Size = new System.Drawing.Size(110, 17);
            this.rdAddSuppfromPro.TabIndex = 4;
            this.rdAddSuppfromPro.Text = "Add New Supplier";
            this.rdAddSuppfromPro.UseVisualStyleBackColor = true;
            this.rdAddSuppfromPro.CheckedChanged += new System.EventHandler(this.rdAddSuppfromPro_CheckedChanged);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(112, 53);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(191, 20);
            this.txtProduct.TabIndex = 6;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(135, 193);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(339, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbSelectProd
            // 
            this.cmbSelectProd.FormattingEnabled = true;
            this.cmbSelectProd.Location = new System.Drawing.Point(112, 26);
            this.cmbSelectProd.Name = "cmbSelectProd";
            this.cmbSelectProd.Size = new System.Drawing.Size(191, 21);
            this.cmbSelectProd.TabIndex = 9;
            // 
            // rdAddNewProd
            // 
            this.rdAddNewProd.AutoSize = true;
            this.rdAddNewProd.Location = new System.Drawing.Point(11, 42);
            this.rdAddNewProd.Name = "rdAddNewProd";
            this.rdAddNewProd.Size = new System.Drawing.Size(109, 17);
            this.rdAddNewProd.TabIndex = 10;
            this.rdAddNewProd.Text = "Add New Product";
            this.rdAddNewProd.UseVisualStyleBackColor = true;
            // 
            // rdSelectProd
            // 
            this.rdSelectProd.AutoSize = true;
            this.rdSelectProd.Checked = true;
            this.rdSelectProd.Location = new System.Drawing.Point(11, 15);
            this.rdSelectProd.Name = "rdSelectProd";
            this.rdSelectProd.Size = new System.Drawing.Size(126, 17);
            this.rdSelectProd.TabIndex = 11;
            this.rdSelectProd.TabStop = true;
            this.rdSelectProd.Text = "Select From Products";
            this.rdSelectProd.UseVisualStyleBackColor = true;
            this.rdSelectProd.CheckedChanged += new System.EventHandler(this.rdSelectProd_CheckedChanged);
            // 
            // lblAddProd
            // 
            this.lblAddProd.AutoSize = true;
            this.lblAddProd.Location = new System.Drawing.Point(12, 56);
            this.lblAddProd.Name = "lblAddProd";
            this.lblAddProd.Size = new System.Drawing.Size(75, 13);
            this.lblAddProd.TabIndex = 12;
            this.lblAddProd.Text = "Product Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdSelectProd);
            this.panel1.Controls.Add(this.rdAddNewProd);
            this.panel1.Location = new System.Drawing.Point(318, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 85);
            this.panel1.TabIndex = 13;
            // 
            // frmAddModifyProducts
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(463, 240);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAddProd);
            this.Controls.Add(this.cmbSelectProd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.rdAddSuppfromPro);
            this.Controls.Add(this.rdSelectSupFroPro);
            this.Controls.Add(this.lblSelProd);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cmbSuppliers);
            this.Name = "frmAddModifyProducts";
            this.Text = "frmAddModifyProducts";
            this.Load += new System.EventHandler(this.frmAddModifyProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblSelProd;
        private System.Windows.Forms.RadioButton rdSelectSupFroPro;
        private System.Windows.Forms.RadioButton rdAddSuppfromPro;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbSelectProd;
        private System.Windows.Forms.RadioButton rdAddNewProd;
        private System.Windows.Forms.RadioButton rdSelectProd;
        private System.Windows.Forms.Label lblAddProd;
        private System.Windows.Forms.Panel panel1;
    }
}