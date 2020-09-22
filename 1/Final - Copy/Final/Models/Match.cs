using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
     public class Match
     {
          public int Id { get; set; }
          public int TeamHomeId { get; set; }
          public int TeamAwayId { get; set; }
          public int HomeScore { get; set; }
          public int AwayScore { get; set; }
          public Team Team { get; set; }


     }
}