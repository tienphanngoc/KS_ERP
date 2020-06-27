using KSERP.Data.Entities.Oganization;
using KSERP.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Sales
{
    public class CustomerCareHistory 
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SalesCareId { get; set; }
        public DateTime DateCare { get; set; }
        public CustomerProspects CustomerProspect { get; set; }
        public ContactTypes ContactBy { get; set; }
        public string Content { get; set; }
        public string Result { get; set; }

        //Navigations
        public virtual Customer Customer { get; set; }
        public virtual Employee  Employee { get; set; }

        public CustomerCareHistory()
        {
            ContactBy = ContactTypes.OTHER;
            CustomerProspect = CustomerProspects.COLD;
            Content = "Chưa điền";
            Result = "Chưa điền";
            DateCare = DateTime.Now;
        }
    }
}
