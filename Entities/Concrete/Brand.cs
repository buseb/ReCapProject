using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public int CarBrandId{ get; set; }
        public string CarBrandName { get; set; }

    }
}
