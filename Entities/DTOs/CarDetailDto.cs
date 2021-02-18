using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarBrandName { get; set; }
        public string CarColorName { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }
    }
}
