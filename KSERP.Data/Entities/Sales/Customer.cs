using KSERP.Data.Entities.Oganization;
using KSERP.Data.Enums;
using System;

namespace KSERP.Data.Entities.Sales
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public CustomerSources CustomerSource { get; set; }
        public CustomerProspects CustomerProspect { get; set; }
        public DateTime DoB { get; set; }
        public string Job { get; set; }
        public int CurrentSalesCareId { get; set; }
        //Navigations
        public virtual Employee CurrentSalesCare { get; set; }

        public Customer()
        {
            CustomerProspect = CustomerProspects.COLD;
            CustomerSource = CustomerSources.OTHER;
        }

    }
}
