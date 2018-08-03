using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectForms.Models
{
    /// <summary>
    /// Product Supplier DB
    /// Josh McNabb SAIT 2018
    /// Minor Edits By Olaoluwa Adesanya
    /// </summary>
    public class Products_Supplier
    {
        public int ProductSupplierId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public string ProdName { get; set; }
        public string SupName { get; set; }

        

    }
}
