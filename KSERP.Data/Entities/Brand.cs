using KSERP.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public EntityStatus Status { get; set; }
        public Brand()
        {
            Status = EntityStatus.ACTIVE;
        }    
    }
}
