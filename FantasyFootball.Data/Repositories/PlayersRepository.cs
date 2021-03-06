﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using FantasyFootball.Data.Entities;

namespace FantasyFootball.Data.Repositories
{
  public interface IPlayersRepository
  {
    IEnumerable<Player> Get();
  }

  public class PlayersRepository : IPlayersRepository
  {
    private readonly FantasyFootballContext _context;

    public PlayersRepository(FantasyFootballContext context)
    {
      _context = context;
    }

    public IEnumerable<Player> Get()
    {

      const string KEY = "Players";
      var players = HttpContext.Current.Cache[KEY] as List<Player>;
      if (players == null)
      {
        players = _context.Players.Include("OffensiveProjections").ToList();
        HttpContext.Current.Cache.Insert(KEY, players, null, DateTime.Now.AddDays(7), TimeSpan.Zero );

      }

      return players;
    }
  }
}
