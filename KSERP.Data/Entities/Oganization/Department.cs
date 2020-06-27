using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Oganization
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DealerId { get; set; }

        //Navigations
        public virtual Dealer Dealer { get; set; }

        public Department()
        {
        }
    }
}
