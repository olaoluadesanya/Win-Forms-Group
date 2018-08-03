using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Package 
/// Olaoluwa Adesanya SAIT 2018
/// Performs Crud Operation on the Package Product Supplier table in the Travel Experts Database
/// </summary>
namespace GroupProjectForms.Models
{

    public class Package
    {
        public Package() { }

        public int PackageId { get; set; }

        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Desc { get; set; }

        public decimal BasePrice { get; set; }

        public decimal? AgencyCommission { get; set; }

        public List<Packages_Products_Supplier> packProd { get; set; }
    }
}
