using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FantasyFootball.Data.Entities;
using FantasyFootball.Extensions;

namespace FantasyFootball.Models
{
  public class Players
  {
    public IEnumerable<OffensivePlayer> Quarterbacks { get; set; }
    public IEnumerable<OffensivePlayer> Runningbacks { get; set; }
    public IEnumerable<OffensivePlayer> WideReceivers { get; set; }
    public IEnumerable<OffensivePlayer> TightEnds { get; set; }

    public Players(IEnumerable<Player> players)
    {
      Quarterbacks = players.Where(p => p.Position == Position.QB).ToOffensivePlayers();
      Runningbacks = players.Where(p => p.Position == Position.RB).ToOffensivePlayers();
      WideReceivers = players.Where(p => p.Position == Position.WR).ToOffensivePlayers();
      TightEnds = players.Where(p => p.Position == Position.TE).ToOffensivePlayers();

    }
  }
}