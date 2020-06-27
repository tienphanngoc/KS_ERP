using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Car
{
    public class CarCategoryColor
    {
        public int CarCategoryId { get; set; }
        public int CarColorId { get; set; }

        //Navigations
        public virtual CarCategory CarCategory { get; set; }
        public virtual CarColor CarColor { get; set; }
    }
}
