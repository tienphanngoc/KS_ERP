using KSERP.Data.Entities.Oganization;
using KSERP.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.System
{
    public class User : IdentityUser<int>
    {
        public EntityStatus Status { get; set; }
        //Navigations
        public virtual Employee Employee { get; set; }
        public User()
        {
            Status = EntityStatus.INACTIVE;   
        }
    }
}
