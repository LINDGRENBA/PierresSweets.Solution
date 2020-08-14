using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Bakery.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string Type { get; set; }
    public virtual ICollection<FlavorTreat> Treats { get; set; }
  }
}