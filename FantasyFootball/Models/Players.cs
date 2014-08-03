using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FantasyFootball.Data.Entities;

namespace FantasyFootball.Models
{
  public class Players
  {
    public IEnumerable<Player> Quarterbacks { get; set; }
    public IEnumerable<Player> Runningbacks { get; set; }
    public IEnumerable<Player> WideReceivers { get; set; }
    public IEnumerable<Player> TightEnds { get; set; }

    public Players(IEnumerable<Player> players)
    {
      Quarterbacks = players.Where(p => p.Position == Position.QB);
      Runningbacks = players.Where(p => p.Position == Position.RB);
      WideReceivers = players.Where(p => p.Position == Position.WR);
      TightEnds = players.Where(p => p.Position == Position.TE);

    }
  }
}