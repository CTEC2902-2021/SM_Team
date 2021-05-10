using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Football.Models;


namespace Football.Controllers
{
    public class ClubController : Controller
    {
        private List<Club> Clubs = new List<Club>()
       {
           new Club { ClubId = 1,
                      ClubName = "Manchester City",
                      ClubDescription = "The top flight of english football",
                       PlayerName = "Moses",

           },
            new Club { ClubId = 2,
                      ClubName = "Manchester United",
                      ClubDescription = "The top flight of english football",
                      PlayerName = "Philip",

           },
             new Club { ClubId = 3,
                      ClubName = "Leicester City",
                      ClubDescription = "The top division of England's football eague system",
                       PlayerName = "Matac",


           },
              new Club { ClubId = 4,
                      ClubName = "West Ham United",
                      ClubDescription = "The top tier of english football",
                       PlayerName = "Dhanik",


           },
               new Club { ClubId = 5,
                      ClubName = "Liverpool",
                      ClubDescription = "The club that has won 19 league titles  ",
                       PlayerName = "Zack",


               },
               new Club { ClubId = 6,
                      ClubName = "Everton",
                      ClubDescription = "Professional football club based in Liverpool ",
                       PlayerName = "Moses",



               },
               new Club { ClubId = 7,
                      ClubName = "Leeds United",
                      ClubDescription = " the Football League and took over their Elland Road stadium ",
                       PlayerName = "Moses",




               },
                new Club { ClubId = 8,
                      ClubName = "Arsenal",
                      ClubDescription = " the top flight of the english football",
                       PlayerName = "Moses",




                },
                 new Club { ClubId = 9,
                      ClubName = "Aston Villa",
                      ClubDescription = " Played at their home ground since 1897",
                       PlayerName = "Moses",




                 },
                 new Club { ClubId = 10,
                      ClubName = "Fulham",
                      ClubDescription = " They currently compete in the premier league, the highest level of the English football league system",
                       PlayerName = "Moses",

                 },



       };
     

        // GET: Product
        public ActionResult Index()
        {
            return View(Clubs);
        }

        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            Club selectedClub = Clubs.First(p => p.ClubId == id);

            if (selectedClub == null) return new HttpNotFoundResult();

            return View(selectedClub);
        }
        // GET: Edit/id 
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            Club selectedClub = Clubs.First(p => p.ClubId == id);
            if (selectedClub == null) return new HttpNotFoundResult();
            return View(selectedClub);
        }
    }




}
