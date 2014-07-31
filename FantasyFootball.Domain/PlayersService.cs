using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyFootball.Data.Entities;
using FantasyFootball.Data.Repositories;

namespace FantasyFootball.Domain
{
  public interface IPlayersService
  {
    IEnumerable<Player> GetPlayers();
  }

  public class PlayersService : IPlayersService
  {
      private readonly IPlayersRepository _repository;

      public PlayersService(IPlayersRepository repository)
      {
        _repository = repository;
      }

      public IEnumerable<Player> GetPlayers()
      {
        return _repository.Get();
      } 
    }
}
