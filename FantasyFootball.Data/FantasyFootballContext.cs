using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyFootball.Data.Entities;

namespace FantasyFootball.Data
{
    public class FantasyFootballContext : DbContext
    {
      public DbSet<Player> Players { get; set; }
    }
}
