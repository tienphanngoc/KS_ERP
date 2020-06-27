using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.Car
{
    public class CarCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        //Navigations
        public virtual Brand Brand { get; set; }
    }
}
