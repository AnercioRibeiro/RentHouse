using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentHouseAPI.Models
{
    public class Tenant : BaseEntity
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
