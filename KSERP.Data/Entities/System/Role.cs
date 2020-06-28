using KSERP.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.System
{
    public class Role : IdentityRole<int>
    {
        public EntityStatus Status { get; set; }

        //Navigations
        public virtual HashSet<RolePosition> RolePositions { get; set; }
        public Role()
        {
            Status = EntityStatus.ACTIVE;
            RolePositions = new HashSet<RolePosition>();
        }
    }
}
