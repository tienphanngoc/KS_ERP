using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Oganization
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ushort Level { get; set; }
        public int? ParentId { get; set; }
        public int DepartmentId { get; set; }

        //Navigations
        public virtual Position Parent { get; set; }
        public virtual Department Department { get; set; }
        public virtual HashSet<Position> Childs { get; set; }

        public Position()
        {
            Level = 0;
            Childs = new HashSet<Position>();
        }
    }
}
