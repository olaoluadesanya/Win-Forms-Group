using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectForms.Models
{    /// <summary>
     /// Products
     /// Kyle Hinton SAIT 2018
     /// Minor Edits By Olaoluwa Adesanya
     /// </summary>
    public class Products
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; }
        public List<Products_Supplier> Suppliers { get; set; }
    }    
}
