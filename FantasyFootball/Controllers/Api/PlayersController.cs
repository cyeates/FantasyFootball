using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using FantasyFootball.Data.Entities;
using FantasyFootball.Domain;

namespace FantasyFootball.Controllers.Api
{
  public class PlayersController : ApiController
  {
    private readonly IPlayersService _playersService;

    public PlayersController(IPlayersService playersService)
    {
      _playersService = playersService;
    }

    // GET api/<controller>
    public IEnumerable<Player> Get()
    {
      return _playersService.GetPlayers();
     
    }

    //// GET api/<controller>/5
    //public string Get(int id)
    //{
    //  return "value";
    //}

    
  }
}