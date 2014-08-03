using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootball.Data.Entities
{
  public class Player
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int PlayerId { get; set; }
    public string Name { get; set; }
    public Position Position { get; set; }
    public string TeamId { get; set; }

    public virtual OffensiveProjections OffensiveProjections { get; set; }

    
  }
}
