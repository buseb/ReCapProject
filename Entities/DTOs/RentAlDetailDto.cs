using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentAlDetailDto
    {
        public int RentAlId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
