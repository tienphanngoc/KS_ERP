using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Car
{
    public class CarModelColor
    {
        public int CarModelId { get; set; }
        public int CarColorId { get; set; }

        //Navigations
        public CarModel CarModel { get; set; }
        public CarColor CarColor { get; set; }
    }
}
