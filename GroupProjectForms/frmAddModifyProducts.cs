using GroupProjectForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Add/Modify products
/// Olaoluwa Adesanya SAIT 2018
/// </summary>
namespace GroupProjectForms
{
    public partial class frmAddModifyProducts : Form
    {
        // Declare the arrays and variables
        public bool addProducts;
        public bool editProdSup;
        public int rowIndex;
        public Products product;
        public List<Products> products = new List<Products>();
        public List<Suppliers> suppliers = new List<Suppliers>();
        public Products_Supplier products_supplier = new Products_Supplier();

        
        public frmAddModifyProducts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On form load, check whether we are in add or edit mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddModifyProducts_Load(object sender, EventArgs e)
        {
            loadProdSuppliers();
            if (addProducts) //if add mode display only certain controls
            {
                this.Text = "Add Product";
                this.lblSelProd.Visible = false;
                this.cmbSelectProd.Visible = false;
                this.rdAddNewProd.Visible = false;
                this.rdSelectProd.Visible = false;
            }
            else if (editProdSup) //if edit product supplier mode, show certain things
            {
                this.Text = "Modify Product / Supplier";
                this.lblAddProd.Visible = false;
                this.txtProduct.Visible = false;

            }
            else //else pure editing mode
            {
                this.Text = "Modify Product";
                this.DisplayProducts();
                this.lblSupplier.Visible = false;
                this.cmbSuppliers.Visible = false;
                this.rdSelectSupFroPro.Visible = false;
                this.rdAddSuppfromPro.Visible = false;
                this.lblSelProd.Visible = false;
                this.cmbSelectProd.Enabled = false;
                this.cmbSelectProd.Visible = false;
                this.rdAddNewProd.Visible = false;
                this.rdSelectProd.Visible = false;
            }
        }
        //Display existing products
        private void DisplayProducts()
        {
            txtProduct.Text = product.ProdName.ToString();
        }

        //Load comboboxes for products and suppliers
        private void loadProdSuppliers()
        {
            //Clear datasource before binding
            cmbSuppliers.DataSource = null;
            cmbSuppliers.DataSource = suppliers;
            cmbSuppliers.DisplayMember = "SupName";
            cmbSuppliers.ValueMember = "SupplierID";
            cmbSelectProd.DataSource = null;
            cmbSelectProd.DataSource = products;
            cmbSelectProd.DisplayMember = "ProdName";
            cmbSelectProd.ValueMember = "ProductID";
            cmbSelectProd.SelectedIndex = rowIndex;
        }

        //If add new supplier radio button is changed
        private void rdAddSuppfromPro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAddSuppfromPro.Checked)//open add supplier forms
            {
                Suppliers supplier;
                frmAddModifySuppliers addSupplierForm = new frmAddModifySuppliers();
                addSupplierForm.addSupplier = true;
                DialogResult resultSupplier = addSupplierForm.ShowDialog();
                if (resultSupplier == DialogResult.OK)
                {
                    supplier = addSupplierForm.supplier;
                    suppliers.Add(supplier);
                    loadProdSuppliers();
                    cmbSuppliers.SelectedIndex = suppliers.Count - 1; //select the last added supplier on default
                    cmbSuppliers.Enabled = false;
                }
            }
            else
            {
                //Else allow user to select from combobox
                cmbSuppliers.Enabled = true;
            }
        }

        //Validator
        private bool IsValidData()
        {
            //Only validate if we are adding a new product or if we are editing an existing one

            if (rdAddNewProd.Checked == true || editProdSup == false)
            {
                return Validator.IsPresent(txtProduct);
            }
            else return true;
        }
        //On accept button click
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addProducts) //add products mode
                {
                    
                    product = new Products();
                    Suppliers supplier = suppliers[cmbSuppliers.SelectedIndex];
                    this.PutProductDataAdd(product, supplier);

                    try
                    {
                        product.ProductId = ProductDB.AddProducts(product);
                        products_supplier.ProductSupplierId = Products_SupplierDB.AddProduct_Supplier(product, supplier);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (SqlException ex)
                    {//if sql error occoured
                        switch (ex.Errors[0].Number)
                        {
                            case 2627: //if primary key error
                                MessageBox.Show("You already added this Product", "Duplicate Error");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else if (editProdSup) //edit product supplier mode
                {
                    if(rdAddNewProd.Checked == true) //if add product within this mode
                    {
                        product = new Products();
                        Suppliers supplier = suppliers[cmbSuppliers.SelectedIndex];
                        this.PutProductDataAdd(product, supplier);

                        try
                        {
                            //Add the products
                            product.ProductId = ProductDB.AddProducts(product);
                            products_supplier.ProductSupplierId = Products_SupplierDB.AddProduct_Supplier(product, supplier);
                            this.DialogResult = DialogResult.OK;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }
                    else
                    {
                        //select from the combobox
                        product = products[cmbSelectProd.SelectedIndex];
                        Suppliers supplier = suppliers[cmbSuppliers.SelectedIndex];
                        this.PutProductDataAdd(product, supplier);

                        try
                        {
                            products_supplier.ProductSupplierId = Products_SupplierDB.AddProduct_Supplier(product, supplier);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (SqlException ex)
                        {
                            switch (ex.Errors[0].Number)
                            {
                                case 2627: //Primary key violation
                                    MessageBox.Show(products_supplier.ProdName + " is already supplied by " + products_supplier.SupName , "Duplicate Error");
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }
                   
                }
                else //pure edit product mode
                {
                    Products newProduct = new Products();
                    newProduct.ProductId = product.ProductId;
                    this.PutProductDataEdit(newProduct);
                    try
                    {
                        //Try to edit data
                        if (!ProductDB.UpdateProduct(product, newProduct))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that product.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            //edit returns
                            product = newProduct;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }

        }

        //Hold the data
        private void PutProductDataAdd(Products product, Suppliers supplier)
        {
            product.ProdName = txtProduct.Text;
            supplier.SupplierId = (int)cmbSuppliers.SelectedValue;
        }

        //Hold the data
        private void PutProductDataEdit(Products product)
        {
            product.ProdName = txtProduct.Text;
        }
        /// <summary>
        /// Controls the add or choose products logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdSelectProd_CheckedChanged(object sender, EventArgs e)
        {
            if(rdAddNewProd.Checked == true)
            {
                this.txtProduct.Visible = true;
                this.cmbSelectProd.Enabled = false;
            }
            else
            {
                this.txtProduct.Visible = false;
                this.cmbSelectProd.Enabled = true;
            }
        }
    }
}
