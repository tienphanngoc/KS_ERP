using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Oganization
{
    public class Dealer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string SalesHotline { get; set; }
        public string ServicesHotline { get; set; }
        public int BrandId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTax { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyRepresentBy { get; set; }
        public string RepresentativePosition { get; set; }

        //Navigations
        public virtual Brand Brand { get; set; }
        public virtual HashSet<Department> Departments { get; set; }

        public Dealer()
        {
            Departments = new HashSet<Department>();
        }
    }
}
