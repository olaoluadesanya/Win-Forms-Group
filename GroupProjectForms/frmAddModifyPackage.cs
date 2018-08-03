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
/// <summary>
/// Olaolwa Adesanya
/// SAIT 2018
/// form to add or modify packages
/// </summary>
namespace GroupProjectForms
{
    public partial class frmAddModifyPackage : Form
    {
        public frmAddModifyPackage()
        {
            InitializeComponent();
        }

        public bool addPackage;
        public Package package;

        private void AddModifyPackage_Load(object sender, EventArgs e)
        {


            if (addPackage)
            {
                this.Text = "Add Package";
                dtPkgStart.MinDate = DateTime.Now;

                dtPkgEnd.MinDate = DateTime.Now.AddDays(1);
            }
            else
            {
                this.Text = "Modify Package";
                this.DisplayPackage();
            }
        }

        private void DisplayPackage()
        {
            txtPkgName.Text = package.Name;
            dtPkgStart.Value = (package.StartDate.HasValue)? (DateTime)package.StartDate : dtPkgStart.Value.Date; 
            dtPkgStart.Checked = (package.StartDate.HasValue) ? true : false;
            dtPkgEnd.Value = (package.EndDate.HasValue) ? (DateTime)package.EndDate : dtPkgEnd.Value.Date;
            dtPkgEnd.Checked = (package.EndDate.HasValue) ? true : false;
            txtPkgDesc.Text = package.Desc;
            txtPkgBase.Text = package.BasePrice.ToString();
            txtPkgComm.Text = (package.AgencyCommission.HasValue)?((Decimal)package.AgencyCommission).ToString():"";            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (IsValidData())
            {
                if (addPackage)
                {
                    package = new Package();
                    this.PutPackageData(package);
                    try
                    {
                        package.PackageId = PackagesDB.AddPackage(package);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Package newPackage = new Package();
                    newPackage.PackageId = package.PackageId;
                    this.PutPackageData(newPackage);
                    try
                    {
                        if (!PackagesDB.UpdatePackage(package, newPackage))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that package.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            package = newPackage;
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

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtPkgName) &&
                Validator.IsPresent(txtPkgBase) &&
                Validator.IsPositiveDecimal(txtPkgBase) &&
                Validator.IsPresent(txtPkgDesc) &&
                Validator.IsPositiveDecimal(txtPkgComm) &&
                Validator.IsNullOrLesserThan(txtPkgComm, txtPkgBase);
        }

        private void PutPackageData(Package package)
        {
            package.Name = txtPkgName.Text;
            package.Desc = txtPkgDesc.Text;
            package.BasePrice = Convert.ToDecimal(txtPkgBase.Text);
            package.AgencyCommission = (txtPkgComm.Text != "")? (Decimal?)Convert.ToDecimal(txtPkgComm.Text) : null;
            package.StartDate = (dtPkgStart.Checked) ? dtPkgStart.Value.Date : (DateTime?)null;
            package.EndDate = (dtPkgEnd.Checked) ? dtPkgEnd.Value.Date : (DateTime?)null;
        }



        private void dtPkgStart_ValueChanged(object sender, EventArgs e)
        {
            
            dtPkgEnd.MinDate = dtPkgStart.Value;
        }

 ////       private void dtPkgEnd_ValueChanged(object sender, EventArgs e)
 //       {
 //           dtPkgStart.MaxDate = dtPkgEnd.Value;
 //       }
    }
}
