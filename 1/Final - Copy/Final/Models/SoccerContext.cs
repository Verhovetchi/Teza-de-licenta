﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final.Models
{
     public class SoccerContext:DbContext
     {
          public DbSet<Player> Players { get; set; }
          public DbSet<Team> Teams { get; set; }
          public DbSet<Image> Images { get; set; }
          public DbSet<Match> Matches { get; set; }
     }
}