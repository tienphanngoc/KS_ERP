using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Car
{
    public class CarModelCategory
    {
        public int CarCategoryId { get; set; }
        public int CarModelId { get; set; }

        //Navigations
        public virtual CarCategory CarCategory { get; set; }
        public virtual CarModel CarModel { get; set; }
    }
}
