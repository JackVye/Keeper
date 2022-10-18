using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Keeper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Dungeon()
        {
            List<Keeper.Models.Region> Regions = new List<Keeper.Models.Region>();
            Keeper.Models.Region r = new Keeper.Models.Region();
            r.name = "The Antechamber";
            Regions.Add(r);

            List<Keeper.Models.Unit> Units = new List<Keeper.Models.Unit>();
            Keeper.Models.Unit u = new Models.Unit();
            Keeper.Models.Unit u1 = new Models.Unit();
            Keeper.Models.Unit u2 = new Models.Unit();
            Keeper.Models.Unit u3 = new Models.Unit();
            u.name = "Blinky";
            u.race = "goblin";
            Units.Add(u);
            u1.name = "Bongo";
            u1.race = "goblin";
            Units.Add(u1);
            u2.name = "Birdly";
            u2.race = "little shit";
            Units.Add(u2);
            u3.name = "Kevin";
            u3.race = "human";
            Units.Add(u3);

            List<string> Items = new List<string>();
            Items.Add("shield");
            Items.Add("Amulet of Shielding");
            Items.Add("Shortsword");
            Items.Add("Platemail");

            ViewData["Regions"] = Regions;
            ViewData["Units"] = Units;
            ViewData["Items"] = Items;


            return View();
        }

        public ActionResult Add()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult OneTimeStart()
        {
            ViewBag.Message = "";

            return RedirectToAction("Dungeon");
        }
    }
}