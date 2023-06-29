namespace Core.Models
{
    public class Publication : BaseEntity
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string PictureUrl { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Tipology { get; set; }
        public string Floor { get; set; }
        public string Division { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Elevator { get; set; }
        public string Details { get; set; }
        public string PaymentPeriodicy { get; set; }
        //public decimal Price { get; set; }
        public Province Province { get; set; }
        public int ProvinceId { get; set; }
        public County County { get; set; }
        public int CountyId { get; set; }
        
    }
}
