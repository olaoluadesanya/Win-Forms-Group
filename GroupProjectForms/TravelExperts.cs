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
/// Travel Experts Main Form
/// Olaoluwa Adesanya 2018 SAIT
/// Controls the business logic for the 
/// Travel Experts Windowns management app
/// </summary>
namespace GroupProjectForms
{
    public partial class TravelExperts : Form
    {
        //Initializze the Lists
        List<Package> packages = new List<Package>();
        List<Package> packages2 = new List<Package>(); //two controls cannot share the same datasource
        List<Products> products = new List<Products>();
        List<Products> products2 = new List<Products>(); //two controls cannot share the same datasource
        List<Suppliers> suppliers = new List<Suppliers>();
        List<Products_Supplier> products_suppliers = new List<Products_Supplier>();
        List<Packages_Products_Supplier> packages_products_suppliers = new List<Packages_Products_Supplier>();

        public TravelExperts()
        {
            InitializeComponent();
        }
        /// <summary>
        /// On Load the form
        /// populate all the controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TravelExperts_Load(object sender, EventArgs e)
        {
            btnAdd.Text = "Add Packages";
            btnEdit.Text = "Edit Pakcages";
            btnDelete.Text = "Delete Packages";
            this.displayAll();
        }

        /// <summary>
        /// On tab change
        /// Change the button texts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbMain.SelectedTab.Name)
            {
                case "tabPackages":
                    btnAdd.Text = "Add Packages";
                    btnEdit.Text = "Edit Pakcages";
                    btnDelete.Text = "Delete Packages";
                    break;
                case "tabProducts":
                    btnAdd.Text = "Add Products";
                    btnEdit.Text = "Edit Products";
                    btnDelete.Text = "Delete Products";
                    break;
                case "tabSuppliers":
                    btnAdd.Text = "Add Suppliers";
                    btnEdit.Text = "Edit Suppliers";
                    btnDelete.Text = "Delete Suppliers";
                    break;
                default: //Home PAge
                    btnAdd.Text = "Add Packages";
                    btnEdit.Text = "Edit Pakcages";
                    btnDelete.Text = "Delete Packages";
                    break;

            }
        }

        /// <summary>
        /// Get all the datat from the database
        /// </summary>
        private void getAll()
        {
            try
            {
                packages = PackagesDB.GetAllPackages();
                packages2 = PackagesDB.GetAllPackages(); //Two controls cannot share array data binding
                products = ProductDB.GetAllProducts();
                products2 = ProductDB.GetAllProducts();//Two controls cannot share array data binding
                suppliers = SuppliersDB.GetAllSuppliers();
                products_suppliers = Products_SupplierDB.GetAllProduct_Suppliers();
                
            }
            catch (Exception ex) //Any Errors form the database read?
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// This binds all the controls to the data source
        /// array that is populated from the database
        /// </summary>
        /// <param name="rowIndex">This is used to preserve the state of the Packages table</param>
        /// <param name="rowIndexSec">This is used to preserve the state of the Products table</param>
        /// <param name="sucAdd">This is used to preserve the state of the products in package table</param>
        private void displayAll(int rowIndex = 0, int rowIndexSec = 0, bool sucAdd = false)
        {
            //first populate the arrays
            this.getAll();

            //Set autogeneration for all the tabless to false
            dgPackageProductSuppliers.AutoGenerateColumns = false;
            dgPackages.AutoGenerateColumns = false;
            dgSuppliers.AutoGenerateColumns = false;
            dgProducts.AutoGenerateColumns = false;
            dgProd.AutoGenerateColumns = false;
            dgSup.AutoGenerateColumns = false;
            dgViewSubPack.AutoGenerateColumns = false;

            //Now bind the data sources
            dgPackages.DataSource = packages;
            dgProducts.DataSource = products;
            dgSuppliers.DataSource = suppliers;


            //Current cell is set to preserve the state from previous loads
            dgProd.DataSource = products2;
            dgProd.CurrentCell = dgProd[0, rowIndexSec];
            dgProd.CurrentCell.Selected = true;
            dgSup.DataSource = products[dgProd.CurrentRow.Index].Suppliers;

            //Current cell is set to preserve the state from previous loads
            dgPackageProductSuppliers.DataSource = packages2;
            dgPackageProductSuppliers.CurrentCell = dgPackageProductSuppliers[0, rowIndex];
            dgPackageProductSuppliers.CurrentCell.Selected = true;
            dgViewSubPack.DataSource = packages[dgPackageProductSuppliers.CurrentRow.Index].packProd;
            
            //this preserves the state of the products suppliers in package after an add operation
            //For easier Transversal
            if (sucAdd)
            {
                if(packages[dgPackageProductSuppliers.CurrentRow.Index].packProd.Count > 0)
                {
                    dgViewSubPack.CurrentCell = dgViewSubPack[0, packages[dgPackageProductSuppliers.CurrentRow.Index].packProd.Count - 1];
                    dgViewSubPack.CurrentCell.Selected = true;
                }            
            }
        }

        /// <summary>
        /// On selection changed of the package table in the home page
        /// the product/supplier in the packages should change accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPackageProductSuppliers_SelectionChanged(object sender, EventArgs e)
        {           
            dgViewSubPack.DataSource = packages[dgPackageProductSuppliers.CurrentRow.Index].packProd;
            
        }

        /// <summary>
        /// On changing the products in the home page
        /// The suppliers table should change accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgProd_SelectionChanged(object sender, EventArgs e)
        {
            dgSup.DataSource = products[dgProd.CurrentRow.Index].Suppliers;
        }




        /// <summary>
        /// On clicking the add button, react based on tab selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (tbMain.SelectedTab.Name)
            {
                case "tabPackages":
                    Package package; //create a new package object
                    frmAddModifyPackage addPackageForm = new frmAddModifyPackage(); //create new form instance
                    addPackageForm.addPackage = true; //make it an add form
                    DialogResult resultPackage = addPackageForm.ShowDialog();
                    if (resultPackage == DialogResult.OK) //if result comes back as ok
                    {
                        //add a new package with what form returns
                        package = addPackageForm.package;
                        packages.Add(package);
                        this.displayAll(); //refresh the tables
                        DialogResult dia = MessageBox.Show("Would you like to add products to this package now?", "Add Products", MessageBoxButtons.YesNo); //Extra dialog to send user to home page
                        if (dia == DialogResult.Yes) tbMain.SelectedTab = tabPackageProductSupplier;
                    }
                    break;

                case "tabProducts":
                    Products product; //Create new products object
                    frmAddModifyProducts addProductForm = new frmAddModifyProducts(); //Instantiate new Form
                    addProductForm.addProducts = true;// set add mode to true
                    addProductForm.suppliers = suppliers; //Pass suppliers array to form
                    addProductForm.products = products; //Pass products array to form
                    DialogResult resultProducts = addProductForm.ShowDialog();
                    if (resultProducts == DialogResult.OK)//If add products success
                    {
                        product = addProductForm.product;
                        products.Add(product); //Update array
                        this.displayAll(); //Refresh all controls
                    }

                    break;

                case "tabSuppliers":
                    Suppliers supplier; //Instantiate new supplier
                    frmAddModifySuppliers addSupplierForm = new frmAddModifySuppliers(); //Instantiate new add supplier form
                    addSupplierForm.addSupplier = true; //set add mode to true
                    DialogResult resultSupplier = addSupplierForm.ShowDialog();
                    if (resultSupplier == DialogResult.OK) //If added
                    {
                        supplier = addSupplierForm.supplier;
                        suppliers.Add(supplier); //update array
                        this.displayAll(); //refresh Controls
                    }

                    break;

                case "tabPackageProductSupplier":
                    
                    Package packageHome; //Instantite new package
                    frmAddModifyPackage addPackageFormHome = new frmAddModifyPackage(); //Instantiate add package form
                    addPackageFormHome.addPackage = true; //Set to add mode
                    DialogResult resultPackageHome = addPackageFormHome.ShowDialog();
                    if (resultPackageHome == DialogResult.OK) //If done?
                    {
                        packageHome = addPackageFormHome.package; //collect response from add
                        packages.Add(packageHome);//Update array

                        int rowIndex = dgPackageProductSuppliers.RowCount; //Hold state
                        this.displayAll(rowIndex,0);//refresh controls keeping state
                    }
                    break;
            }
        }
        /// <summary>
        /// On clicking edit button 
        /// react based on current tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            switch (tbMain.SelectedTab.Name)
            {
                case "tabPackages":
                    Package package = packages[dgPackages.CurrentRow.Index];  //take the currently selected package                 
                    frmAddModifyPackage modifyPackageForm = new frmAddModifyPackage();
                    modifyPackageForm.addPackage = false; //create the package form in edit mode
                    modifyPackageForm.package = package; 
                    DialogResult result = modifyPackageForm.ShowDialog();
                    if (result == DialogResult.OK) //if result comes back ok
                    {
                        package = modifyPackageForm.package;
                        packages[dgPackages.CurrentRow.Index] = package; //replace the selected row with the reult from form
                        this.displayAll();
                    }
                    else if (result == DialogResult.Retry) //else stay the same
                    {
                        this.displayAll();
                    }
                    break;

                case "tabProducts":
                    Products product = products[dgProducts.CurrentRow.Index];
                    frmAddModifyProducts modifyProductForm = new frmAddModifyProducts();
                    modifyProductForm.addProducts = false;
                    modifyProductForm.product = product;
                    modifyProductForm.products = products;
                    DialogResult resultProduct = modifyProductForm.ShowDialog();
                    if (resultProduct == DialogResult.OK)
                    {
                        product = modifyProductForm.product;
                        products[dgProducts.CurrentRow.Index] = product;
                        this.displayAll();
                    }
                    else if (resultProduct == DialogResult.Retry)
                    {
                        this.displayAll();
                    }

                    break;

                case "tabSuppliers":
                    Suppliers supplier = suppliers[dgSuppliers.CurrentRow.Index];
                    frmAddModifySuppliers modifySupplierForm = new frmAddModifySuppliers();
                    modifySupplierForm.addSupplier = false;
                    modifySupplierForm.supplier = supplier;
                    DialogResult resultSupplier = modifySupplierForm.ShowDialog();
                    if (resultSupplier == DialogResult.OK)
                    {
                        supplier = modifySupplierForm.supplier;
                        suppliers[dgSuppliers.CurrentRow.Index] = supplier;
                        this.displayAll();
                    }
                    else if (resultSupplier == DialogResult.Retry)
                    {
                        this.displayAll();
                    }

                    break;
                //On homepage
                case "tabPackageProductSupplier":
                    int rowIndex = dgPackageProductSuppliers.CurrentRow.Index; //Preserve application state
                    Package packageHome = packages[rowIndex]; // Take data from packages list
                    frmAddModifyPackage modifyPackageHomeForm = new frmAddModifyPackage(); //Instatiate new form 
                    modifyPackageHomeForm.addPackage = false; // In special add package mode
                    modifyPackageHomeForm.package = packageHome;
                    DialogResult resultHome = modifyPackageHomeForm.ShowDialog();
                    if (resultHome == DialogResult.OK) //If return is OK
                    {
                        package = modifyPackageHomeForm.package;
                        packages[rowIndex] = package; //replace package with result from form
                        this.displayAll(rowIndex); //keep state
                    }
                    else if (resultHome == DialogResult.Retry) //if retry, just reload and keep state
                    {
                        this.displayAll(rowIndex);
                    }
                    break;
            }
        }

        /// <summary>
        /// On clicking delete respond based on tab selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (tbMain.SelectedTab.Name)
            {
                case "tabPackages": //take the currently selected package  
                    Package package = packages[dgPackages.CurrentRow.Index];
                    DialogResult result = MessageBox.Show("Delete " + package.Name + "? \nThis will delete the entire package and its components",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) //if user confirms delete
                    {
                        try
                        {
                            if (!PackagesDB.DeletePackage(package))
                            {
                                //Check for optimistic concurrency
                                MessageBox.Show("Another user has updated or deleted " +
                                    "that package.", "Database Error");
                            }
                            else
                            {
                                //Delete successful, refresh the tables
                                dgPackageProductSuppliers.ClearSelection();
                                this.displayAll(0, 0);
                            }

                        }
                        catch (SqlException ex)
                        {
                            switch (ex.Errors[0].Number)
                            {
                                //if foriegn key error from db
                                case 547:
                                    MessageBox.Show("You do not have the priviledge to delete this package", "Priviledge Error");
                                    break;
                            }

                        }
                        catch (Exception ex)
                        {
                            //any other errors
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }

                    break;

                case "tabProducts":
                    int rowIndexProd = dgProducts.CurrentRow.Index;
                    Products product = products[rowIndexProd];
                    DialogResult resultProduct = MessageBox.Show("Delete " + product.ProdName + "?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultProduct == DialogResult.Yes)
                    {
                        try
                        {
                            if (!ProductDB.DeleteProduct(product))
                            {
                                MessageBox.Show("Another user has updated or deleted " +
                                    "that product.", "Database Error");
                            }
                            else
                                dgProd.ClearSelection();
                                rowIndexProd = rowIndexProd - 1; //leave selection on the last product
                                this.displayAll(0, rowIndexProd);
                        }
                        catch (SqlException ex)
                        {
                            switch (ex.Errors[0].Number)
                            {
                                //if foreign key error from datbase
                                case 547:
                                    MessageBox.Show("Please Remove " + product.ProdName + " from all packages before deleting ",
                                        "Link Violation");
                                    break;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }

                    break;

                case "tabSuppliers":
                    Suppliers supplier = suppliers[dgSuppliers.CurrentRow.Index];
                    DialogResult resultSupplier = MessageBox.Show("Delete " + supplier.SupName + "?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultSupplier == DialogResult.Yes)
                    {
                        try
                        {
                            if (!SuppliersDB.DeleteSupplier(supplier))
                            {
                                MessageBox.Show("Another user has updated or deleted " +
                                    "that supplier.", "Database Error");
                            }
                            else
                                this.displayAll();
                        }
                        catch (SqlException ex)
                        {
                            switch (ex.Errors[0].Number)
                            {
                                // if foriegn key error from database
                                case 547:
                                    MessageBox.Show("You cannot delete this supplier as it is linked to a package", "Link Violation");
                                    break;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }

                    break;

                case "tabPackageProductSupplier":
                    int rowIndex = dgPackageProductSuppliers.CurrentRow.Index;
                    Package packageProd = packages[rowIndex];
                    DialogResult resultProd = MessageBox.Show("Delete " + packageProd.Name + "? \nThis will delete the entire package and its components",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultProd == DialogResult.Yes)
                    {
                        try
                        {
                            if (!PackagesDB.DeletePackage(packageProd))
                            {
                                MessageBox.Show("Another user has updated or deleted " +
                                    "that package.", "Database Error");
                            }
                            else
                            {
                                dgPackageProductSuppliers.ClearSelection();
                                rowIndex -= 1;
                                this.displayAll(rowIndex, 0);
                            }

                        }
                        catch (SqlException ex)
                        {
                            switch (ex.Errors[0].Number)
                            {
                                //if foriegn key error from dataabase
                                case 547:
                                    MessageBox.Show("You do not have the priviledge to delete this package", "Priviledge Error");
                                    break;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }

                    break;
            }
        }

        //Application Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// On clicking add product to package button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProdtoPack_Click(object sender, EventArgs e)
        {
            int rowIndexSec = dgProd.CurrentRow.Index; //needed to preserve state of tables
            Products selectedProduct = products[rowIndexSec]; //selected product from product array
            int rowIndex = dgPackageProductSuppliers.CurrentRow.Index; //needed to preserve state
            Package selectedPackage = packages[rowIndex]; // selected package array to add to
            Products_Supplier selectedSupplier = selectedProduct.Suppliers[dgSup.CurrentRow.Index]; //selected product supplier to add to package
            DialogResult result = MessageBox.Show( //confirm add?
            "You are about to add the product " + selectedProduct.ProdName + " by \n\n" +
            selectedSupplier.SupName + " to "
            + selectedPackage.Name, "Add to Package?",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) 
            {
                try
                {
                    Packages_Products_SuppliersDB.AddPackages_Products_Supplier(selectedPackage, selectedSupplier);
                }
                catch (SqlException ex)
                {
                    switch (ex.Errors[0].Number)
                    {
                        //if primary key error is encountered
                        case 2627:
                            MessageBox.Show("You already added this Product", "Duplicate Error");
                            break;
                    }
                }
                catch(Exception ex) // catch any other issus
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                finally
                {
                    //display all, and keep state
                    this.displayAll(rowIndex, rowIndexSec, true);
                }
                
            }
        }

        /// <summary>
        /// On clicking drop products from packages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDropPro_Click(object sender, EventArgs e)
        {
            //only activate button if that datagrid view has some elements
            if (dgViewSubPack.Rows.Count > 0)
            {
                int rowIndex = dgPackageProductSuppliers.CurrentRow.Index; //needed to preserve state
                int rowIndexSec = dgProd.CurrentRow.Index; //Just to preserve state
                Package selectedPackage = packages[rowIndex]; //Package to drop from
                Packages_Products_Supplier package_product_supplier = packages[rowIndex].packProd[dgViewSubPack.CurrentRow.Index];//product supplier to drop
                DialogResult resultPackageProductSupplier = MessageBox.Show("You are about to remove the product " 
                    + package_product_supplier.ProdName +
                    " by \n\n" + package_product_supplier.SupName +  " from " + selectedPackage.Name + " ? ",
                "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultPackageProductSupplier == DialogResult.Yes)
                {
                    try
                    {   //if not concurrent
                        if (!Packages_Products_SuppliersDB.DeletePackages_Products_Supplier(package_product_supplier))
                        {
                            MessageBox.Show("Another user has updated or deleted " +
                                "that product.", "Database Error");
                        }
                        //else refresh page
                        else
                            this.displayAll(rowIndex, rowIndexSec, true);
                    }
                    //Catch any other error
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
            

        }

        private void rdAddProducts_CheckedChanged(object sender, EventArgs e)
        {
           if(rdAddProducts.Checked == true)
           {
                int rowIndex = dgPackageProductSuppliers.CurrentRow.Index; //to keep state at return
                int rowIndexSec = dgProd.CurrentRow.Index; //to keep data grid state at return
                Products product;
                frmAddModifyProducts addProductSuppForm = new frmAddModifyProducts();
                addProductSuppForm.rowIndex = rowIndexSec; //to initialize the combobox
                addProductSuppForm.editProdSup = true; //make sure the edit product suppliers form is open
                addProductSuppForm.suppliers = suppliers; 
                addProductSuppForm.products = products;
                DialogResult resultProducts = addProductSuppForm.ShowDialog();
                if (resultProducts == DialogResult.OK) //if result is ok, a new product was addedd
                {
                    product = addProductSuppForm.product;
                    products2.Add(product);
                    rowIndexSec = products2.Count - 1; // so reduce list index
                    this.displayAll(rowIndex, rowIndexSec);                  
                }
                else if (resultProducts == DialogResult.Yes) //if yes, an existing product was selected
                {
                    product = addProductSuppForm.product;
                    this.displayAll(rowIndex, rowIndexSec); //so just keep index refreshed
                }
                rdAddProducts.Checked = false; //remove the check after
            }
        }
    }
}
