using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.Entity.Migrations;

namespace Final.Controllers
{
     public class HomeController : Controller
     {
          PageContext pageContextDB = new PageContext();

          SoccerContext soccerDB = new SoccerContext();
          public ActionResult Index(int page = 1)
          {
               int pageSize = 5;
               IEnumerable<New> newsPerPages = pageContextDB.News.
                    Include(n => n.picture).
                    OrderBy(x => x.Id).
                    Skip((page - 1) * pageSize).
                    Take(pageSize).ToList();

               PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = pageContextDB.News.Count() };
               IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, News = newsPerPages };


               return View(ivm);
          }

          public ActionResult Clasament()
          {

               return PartialView();
          }

          public ActionResult Test()
          {
               var matches = soccerDB.Matches.Include(m=>m.Team);
               return View(matches);
          }

          //public ActionResult Test()
          //{
          //     SoccerContext soccer = new SoccerContext();
          //}

          //SoccerContext db2 = new SoccerContext();

          //public ActionResult Index2()
          //{
          //     var teams = db2.Teams.Include(t => t.picture);

          //     return View(teams.ToList());
          //}

          public ActionResult Team(int id)
          {
               var players = soccerDB.Database.SqlQuery<Player>("SELECT * FROM Players where TeamId=" + id);

               ViewBag.Players = players;

               return View();
          }


          //protected override void Dispose(bool disposing)
          //{
          //     db.Dispose();
          //     base.Dispose(disposing);
          //}
     }
}