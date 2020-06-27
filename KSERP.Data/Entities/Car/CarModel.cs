using KSERP.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Car
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Engine { get; set; }
        public string GearBox { get; set; }
        public ushort YOM { get; set; }
        public ushort MY { get; set; }
        public uint SalesPrice { get; set; }
        public string Note { get; set; }
        public EntityStatus Status { get; set; }

        //Navigations
        public virtual HashSet<CarModelCategory> CarModelCategories { get; set; }
        public virtual HashSet<CarModelColor> CarModelColors { get; set; }
        public CarModel()
        {
            CarModelCategories = new HashSet<CarModelCategory>();
            CarModelColors = new HashSet<CarModelColor>();
            YOM = (ushort)DateTime.Now.Year;
            MY = (ushort)DateTime.Now.Year;
        }
    }
}
