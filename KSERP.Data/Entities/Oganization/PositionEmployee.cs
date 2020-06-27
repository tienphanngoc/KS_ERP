using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Oganization
{
    public class PositionEmployee
    {
        public int PositionId { get; set; }
        public int EmployeeId { get; set; }

        //Navigations
        public virtual Position Position { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
