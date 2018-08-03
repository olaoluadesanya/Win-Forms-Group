using GroupProjectForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectForms
{
    /// <summary>
    /// creates a form to add or modify suppliers
    /// Farshid Papei SAIT 2018
    /// </summary>
    public partial class frmAddModifySuppliers : Form
    {
        public frmAddModifySuppliers()
        {
            InitializeComponent();
        }
        // Validator test
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtSupName)&&
                Validator.IsPresent(txtSupID);
        }
        //variables initialization
        public bool addSupplier;
        public Suppliers supplier;

        //if edit mode, display suppliers
        private void DisplaySupplier()
        {
            txtSupID.Text = supplier.SupplierId.ToString();
            txtSupName.Text = supplier.SupName;
        }

        /// <summary>
        /// On accept button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData()) // first validate
            {
                if (addSupplier)
                {
                    supplier = new Suppliers();
                    this.PutSupplierData(supplier);
                    try
                    {
                        if (SuppliersDB.AddSuppliers(supplier))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("There was an error adding that supplier", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Suppliers newSupplier = new Suppliers();
                    newSupplier.SupplierId = supplier.SupplierId;
                    this.PutSupplierData(newSupplier);
                    try
                    {
                        if (!SuppliersDB.UpdateSupplier(supplier, newSupplier))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that supplier.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            supplier = newSupplier;
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

        private void PutSupplierData(Suppliers supplier)
        {
            supplier.SupName = txtSupName.Text;
            supplier.SupplierId = Convert.ToInt32(txtSupID.Text);
        }

        private void frmAddModifySuppliers_Load(object sender, EventArgs e)
        {
            if (addSupplier)
            {
                this.Text = "Add Supplier";
            }
            else
            {
                this.Text = "Modify Supplier";
                this.DisplaySupplier();
            }
        }
    }
}
