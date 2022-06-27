using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Model;

    public class MegaDeskContext : DbContext
    {
        public MegaDeskContext (DbContextOptions<MegaDeskContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk.Model.DeskQuote>? DeskQuote { get; set; }
        public DbSet<MegaDesk.Model.Desk>? Desk { get; set; }
        public DbSet<MegaDesk.Model.DesktopMaterial>? DesktopMaterial { get; set; }
        public DbSet<MegaDesk.Model.Delivery>? Delivery { get; set; }

    }
