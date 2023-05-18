using System.ComponentModel.DataAnnotations;

namespace MVC_Demo_2.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        public ICollection<Club> Clubs { get; set; }

        public ICollection<Race> Races { get; set; }
    }
}
