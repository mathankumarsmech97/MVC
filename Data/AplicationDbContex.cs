using Microsoft.EntityFrameworkCore;
using MVC_Demo_2.Models;

namespace MVC_Demo_2.Data
{
    public class AplicationDbContex :DbContext
    {
        public AplicationDbContex(DbContextOptions<AplicationDbContex> options): base(options) 
        { 
          
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Club> Clubs { get; set; }


    }
}
