using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            game G = new game()
            {
                Str = "GAME START ONE",
                Str1 = "Click on all the animals who have Trunk",
                Str2 = "One Animal is missing from the ZOO!Tell us which one",
                Round = 1,
                Count = 0,
                Totalcount = 0
            };
            return View(G);
        }
        public ActionResult AIndex(int id=0, int idd=1, int iddd=1)
        {
            game R = new game
            {
                Count = id,
                Round =  idd,
                Totalcount = iddd
                
            };
            if(idd ==1)
            {
                R.Str = "GAME START ONE";
                R.Str1 = "Click on all the animals who have Trunk";
                R.Str2 = "One Animal is missing from the ZOO!Tell us which one";
            }
            else if(idd==2)
            {
                R.Str = "GAME START TWO";
                R.Str1 = "Click on all the animals who are Brown";
                R.Str2 = "";
            }
            else if (idd == 3)
            {
                R.Str = "GAME START THREE";
                R.Str1 = "Click on all the animals who have Stripes";
                R.Str2 = "";
            }
            else if (idd == 4)
            {
                R.Str = "GAME START FOUR";
                R.Str1 = "Click on all the animals who do not have Trunk, are not Brown, don't have Stripes and are not White";
                R.Str2 = "";
            }

            return View("Index",R);
        }

            public ActionResult IIndex(int id, int idd, int iddd)
        {
            game model = new game();

           
            if (id ==  1)
            {
                model.Str = "TRY AGAIN";
                model.Count = 1;
                model.Round = idd;
                model.Totalcount = iddd;
            }
            else if (id == 2)
            {
                model.Str = "LOSER!!!  GAME OVER  !!!!";
                model.Round = idd;
                model.Totalcount = iddd;
            }
            else if(id==300)
            {
                model.Str = "GAME START TWO";
                model.Str1 = "Click on all the animals who are Brown";
                model.Str2 = "";
                model.Round = 2;
                model.Count = 0;
                model.Totalcount = 0;
            }
            else if (id == 400)
            {
                model.Str = "GAME START THREE";
                model.Str1 = "Click on all the animals who have Stripes";
                model.Str2 = "";
                model.Round = 3;
                model.Count = 0;
                model.Totalcount = 0;
            }
            else if (id == 500)
            {
                model.Str = "GAME START FOUR";
                model.Str1 = "Click on all the animals who do not have Trunk, are not Brown, don't have Stripes and are not White";
                model.Str2 = "";
                model.Round = 4;
                model.Count = 0;
                model.Totalcount = 0;
            }
            else if (id == 600)
            {
                model.Str = "********************************WINNER************************************************";
                model.Str1 = "*******************************YOU ARE THE STAR**************************************";
                model.Str2 = "";
                model.Round = 0;
                model.Count = 0;
                model.Totalcount = 0;
            }
            else
            {
                model.Str = "LOSER!!!  GAME OVER";
                model.Round = idd;
                model.Totalcount = 0;
            }
            return View("Index",model);
        }

       
        }
}
