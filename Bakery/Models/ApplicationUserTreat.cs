using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel;
using System;
//join table for users and treats

namespace Bakery.Models
{
  public class ApplicationUserTreat
  {
    public int ApplicationUserTreatId { get; set; } //id for join table
    public int TreatId { get; set; } //treat object and treatid for this relationship
    public Treat Treat { get; set; }
    public string ApplicationUserId { get; set; } //attempt to see if adding this line will fix issues with treat editing
    public ApplicationUser ApplicationUser { get; set; } //user object for this relationship
    // applicationuserid is automatically generated in the join table
  }
}