using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectForms.Models
{
    /// <summary>
    /// Package Product Supplier
    /// Farshid Papaei SAIT 2018
    /// Minor Edits By Olaoluwa Adesanya
    /// </summary>
    public class Packages_Products_Supplier
    {
        public int PackageId { get; set; }
        public int ProductSupplierId { get; set; }
        public string ProdName { get; set; }
        public string SupName { get; set; }
    }
}
