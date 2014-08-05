using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http;
using FantasyFootball.Data.Entities;
using FantasyFootball.Domain;
using FantasyFootball.Models;

namespace FantasyFootball.Controllers.Api
{
  public class PlayersController : ApiController
  {
    private readonly IPlayersService _playersService;

    public PlayersController(IPlayersService playersService)
    {
      _playersService = playersService;
    }
    
    public Players Get()
    {
      var players = _playersService.GetPlayers();
      return new Players(players);
     
    }
    
  }
}