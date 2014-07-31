using FantasyFootball.Data;
using FantasyFootball.Data.Repositories;
using FantasyFootball.Domain;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace FantasyFootball
{
  public static class UnityConfig
  {
    public static void RegisterComponents()
    {
      var container = new UnityContainer();
      
      container.RegisterType<IPlayersRepository, PlayersRepository>();
      container.RegisterType<IPlayersService, PlayersService>();
      container.RegisterType<FantasyFootballContext, FantasyFootballContext>();

      GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
    }
  }
}