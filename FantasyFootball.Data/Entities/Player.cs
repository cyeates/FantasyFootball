using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootball.Data.Entities
{
  public class Player
  {
    public int PlayerId { get; set; }
    public string Name { get; set; }
    public Position Position { get; set; }
    public string TeamId { get; set; }
    public double PassYards { get; set; }
    public double PassTds { get; set; }
    public double PassInt { get; set; }
    public double RushYards { get; set; }
    public double RushTds { get; set; }
    public double Receptions { get; set; }
    public double ReceptionYards { get; set; }
    public double ReceptionTds { get; set; }
    public double TwoPts { get; set; }
    public double Fumbles { get; set; }
    public int Test { get; set; }
  }
}
