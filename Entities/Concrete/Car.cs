﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        
            public int CarId { get; set; }
            public string CarName { get; set; }
            public int CarBrandId { get; set; }
            public int CarColorId { get; set; }
            public int ModelYear { get; set; }
            public int DailyPrice { get; set; }
            public string Description { get; set; }
            
    }
}