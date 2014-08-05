using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FantasyFootball.Data.Entities;
using FantasyFootball.Models;

namespace FantasyFootball.Extensions
{
  public static class PlayerExtensions
  {

    public static IEnumerable<OffensivePlayer> ToOffensivePlayers(this IEnumerable<Player> source)
    {
      return source.Where(p => p.OffensiveProjections != null).Select(p => new OffensivePlayer
      {
        PlayerId = p.PlayerId,
        Name = p.Name,
        Position = p.Position,
        TeamId = p.TeamId,
        PassYards = p.OffensiveProjections.PassYards,
        PassTds = p.OffensiveProjections.PassTds,
        PassInt = p.OffensiveProjections.PassInt,
        RushYards = p.OffensiveProjections.RushYards,
        RushTds = p.OffensiveProjections.RushTds,
        Receptions = p.OffensiveProjections.Receptions,
        ReceptionYards = p.OffensiveProjections.ReceptionYards,
        ReceptionTds = p.OffensiveProjections.ReceptionTds,
        TwoPts = p.OffensiveProjections.TwoPts,
        Fumbles = p.OffensiveProjections.Fumbles

      });
    }

  }
}