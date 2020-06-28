using KSERP.Data.Entities.Oganization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.System
{
    public class RolePosition
    {
        public int PositionId { get; set; }
        public int RoleId { get; set; }

        //Navigations
        public virtual Position Position { get; set; }
        public virtual Role Role { get; set; }
    }
}
