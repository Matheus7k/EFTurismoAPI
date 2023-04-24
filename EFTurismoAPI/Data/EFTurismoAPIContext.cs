using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFTurismoAPI.Models;

namespace EFTurismoAPI.Data
{
    public class EFTurismoAPIContext : DbContext
    {
        public EFTurismoAPIContext (DbContextOptions<EFTurismoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<EFTurismoAPI.Models.City> City { get; set; } = default!;

        public DbSet<EFTurismoAPI.Models.Address>? Address { get; set; }

        public DbSet<EFTurismoAPI.Models.Hotel>? Hotel { get; set; }

        public DbSet<EFTurismoAPI.Models.Client>? Client { get; set; }

        public DbSet<EFTurismoAPI.Models.Ticket>? Ticket { get; set; }

        public DbSet<EFTurismoAPI.Models.Package>? Package { get; set; }
    }
}
