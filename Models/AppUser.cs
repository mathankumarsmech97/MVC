﻿using System.ComponentModel.DataAnnotations;

namespace MVC_Demo_2.Models
{
    public class AppUser
    {
        [Key]
        public int AppUserId { get; set; }
        public int? Page { get; set; }

        public int? Mileage { get; set; }                                                         

        public Address? Address { get; set;}

        public ICollection<Club> Clubs { get; set;}

        public ICollection<Race> Races { get; set;}
    }
}
