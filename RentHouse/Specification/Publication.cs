using RentHouseAPI.Models;

namespace RentHouseAPI.Specification
{
    public class Publication : BaseEntity
    {
        public string Identifier { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Tipology { get; set; }
        public string Floor { get; set; }
        public string Division { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Elevator { get; set; }
        public string Details { get; set; }
        public string PaymentPeriodicy {get; set; }
        public Double Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
