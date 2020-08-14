using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Bakery.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public virtual ICollection<FlavorTreat> Flavors { get; set; }
    public virtual ApplicationUser ApplicationUser { get; set; } //associates user with this treat

  }
}