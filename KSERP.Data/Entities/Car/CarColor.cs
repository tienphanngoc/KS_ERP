using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Car
{
    public class CarColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string HEXCode { get; set; }

        //Navigations
        public virtual HashSet<CarCategoryColor> CarCategoryColors { get; set; }
        public CarColor()
        {
            CarCategoryColors = new HashSet<CarCategoryColor>();
        }
    }
}
