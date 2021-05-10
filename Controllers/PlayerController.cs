﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Football.Models;

namespace Football.Controllers
{
    public class PlayerController : Controller
    {
        private List<Player> Players = new List<Player>()
        {
            new Player{ PlayerId = 1,
                        PlayerName = "Moses",
                        PlayerAge = 25,
                        TeamName = "Manchester City",
                        NumberOfFans = 15000,
                        AddComments = "",
            },
             new Player{ PlayerId = 2,
                        PlayerName = "Philip",
                        PlayerAge = 22,
                        TeamName = "Manchester City",
                        NumberOfFans = 13000,
                        AddComments = "",
            },
             new Player{ PlayerId = 3,
                        PlayerName = "Matac",
                        PlayerAge = 21,
                        TeamName = "Manchester City",
                        NumberOfFans = 12000,
                        AddComments = "",
            },
              new Player{ PlayerId = 4,
                        PlayerName = "Dhanik",
                        PlayerAge = 23,
                        TeamName = "Manchester City",
                        NumberOfFans = 18000,
                        AddComments = "",
            },
              new Player{ PlayerId = 5,
                        PlayerName = "Zack",
                        PlayerAge = 30,
                        TeamName = "Manchester City",
                        NumberOfFans = 15000,
                        AddComments = "",

              },
              new Player{ PlayerId = 6,
                        PlayerName = "Bob",
                        PlayerAge = 26,
                        TeamName = "Manchester United",
                        NumberOfFans = 100,
                        AddComments = "",
              },
                new Player{ PlayerId = 7,
                        PlayerName = "Matt",
                        PlayerAge = 32,
                        TeamName = "Manchester United",
                        NumberOfFans = 200,
                        AddComments = "",
              },
                  new Player{ PlayerId = 8,
                        PlayerName = "Jack",
                        PlayerAge = 35,
                        TeamName = "Manchester United",
                        NumberOfFans = 1600,
                         AddComments = "",


              },
                    new Player{ PlayerId = 9,
                        PlayerName = "Dan",
                        PlayerAge = 17,
                        TeamName = "Manchester United",
                        NumberOfFans = 1800,
                         AddComments = "",
              },
                      new Player{ PlayerId = 10,
                        PlayerName = "David",
                        PlayerAge = 18,
                        TeamName = "Manchester United",
                        NumberOfFans = 500,
                         AddComments = "",
              },
                        new Player{ PlayerId = 11,
                        PlayerName = "Pulin",
                        PlayerAge = 20,
                        TeamName = "Leicester City",
                        NumberOfFans =300,
                         AddComments = "",
              },
                          new Player{ PlayerId = 12,
                        PlayerName = "Keian",
                        PlayerAge = 30,
                        TeamName = "Leicester City",
                        NumberOfFans = 156,
                         AddComments = "",
              },
                            new Player{ PlayerId = 13,
                        PlayerName = "Cheslea",
                        PlayerAge = 35,
                        TeamName = "Leicester City",
                        NumberOfFans = 158,
                         AddComments = "",
              },
                              new Player{ PlayerId = 14,
                        PlayerName = "Rhyas",
                        PlayerAge = 32,
                        TeamName ="Leicester City",
                        NumberOfFans = 190,
                         AddComments = "",
              },
                                new Player{ PlayerId = 15,
                        PlayerName = "Ryan",
                        PlayerAge = 24,
                        TeamName = "Leicester City",
                        NumberOfFans = 189,
                         AddComments = "",
              },
                                  new Player{ PlayerId = 16,
                        PlayerName = "Luke",
                        PlayerAge = 25,
                        TeamName = "West Ham United",
                        NumberOfFans = 167,
                         AddComments = "",
              },
                          new Player{ PlayerId = 17,
                        PlayerName = "Darein",
                        PlayerAge = 27,
                        TeamName = "West Ham United",
                        NumberOfFans = 178,
                         AddComments = "",
              },
                            new Player{ PlayerId = 18,
                        PlayerName = "Simpn",
                        PlayerAge = 29,
                        TeamName = "West Ham United",
                        NumberOfFans = 678,
                         AddComments = "",
              },
                              new Player{ PlayerId = 19,
                        PlayerName = "Sam",
                        PlayerAge = 20,
                        TeamName = "West Ham United",
                        NumberOfFans = 167,
                         AddComments = "",
              },
                                new Player{ PlayerId = 20,
                        PlayerName = "Luis",
                        PlayerAge = 17,
                        TeamName = "West Ham United",
                        NumberOfFans = 134,
                         AddComments = "",
              },
                                  new Player{ PlayerId = 21,
                        PlayerName = "Daniel",
                        PlayerAge = 27,
                        TeamName = "Liverpool",
                        NumberOfFans = 109,
                         AddComments = "",
              },
                          new Player{ PlayerId = 22,
                        PlayerName = "Whytt",
                        PlayerAge = 24,
                        TeamName = "Liverpool",
                        NumberOfFans = 198,
                         AddComments = "",
              },
                            new Player{ PlayerId = 23,
                        PlayerName = "Tom",
                        PlayerAge = 23,
                        TeamName = "Liverpool",
                        NumberOfFans = 300,
                         AddComments = "",
              },
                              new Player{ PlayerId = 24,
                        PlayerName = "Harry",
                        PlayerAge = 22,
                        TeamName = "Liverpool",
                        NumberOfFans = 1678,
                         AddComments = "",
              },
                                new Player{ PlayerId = 25,
                        PlayerName = "Jerry",
                        PlayerAge = 27,
                        TeamName = "Liverpool",
                        NumberOfFans = 980,
                         AddComments = "",
              },
                                  new Player{ PlayerId = 26,
                        PlayerName = "Pepa",
                        PlayerAge = 30,
                        TeamName = "Everton",
                        NumberOfFans = 349,
                         AddComments = "",
              },
                          new Player{ PlayerId = 27,
                        PlayerName = "Luicefer",
                        PlayerAge = 34,
                        TeamName = "Everton",
                        NumberOfFans = 457,
                         AddComments = "",
              },
                            new Player{ PlayerId = 28,
                        PlayerName = "Jordan",
                        PlayerAge = 30,
                        TeamName = "Everton",
                        NumberOfFans = 567,
                         AddComments = "",
              },
                              new Player{ PlayerId = 29,
                        PlayerName = "Zen",
                        PlayerAge = 23,
                        TeamName = "Everton",
                        NumberOfFans = 897,
                         AddComments = "",
              },
                                new Player{ PlayerId = 30,
                        PlayerName = "Leo",
                        PlayerAge = 24,
                        TeamName = "Everton",
                        NumberOfFans = 908,
                         AddComments = "",
              },
                                  new Player
                         {
                        PlayerId = 28,
                        PlayerName = "Zack",
                        PlayerAge = 30,
                        TeamName = "Leeds United",
                        NumberOfFans = 739,
                         AddComments = "",
              },
                          new Player
                        {
                        PlayerId = 32,
                        PlayerName = "Oek",
                        PlayerAge = 30,
                        TeamName = "Leeds United",
                        NumberOfFans = 457,
                         AddComments = "",
              },
                            new Player{ PlayerId = 33,
                        PlayerName = "Rompo",
                        PlayerAge = 30,
                        TeamName = "Leeds United",
                        NumberOfFans = 984,
                         AddComments = "",
              },
                              new Player{ PlayerId = 34,
                        PlayerName = "Krish",
                        PlayerAge = 23,
                        TeamName = "Leeds United",
                        NumberOfFans = 2347,
                         AddComments = "",
              },
                                new Player{ PlayerId = 35,
                        PlayerName = "Kar",
                        PlayerAge = 24,
                        TeamName ="Leeds United",
                        NumberOfFans = 490,
                         AddComments = "",
              },
                                  new Player{ PlayerId = 36,
                        PlayerName = "Cakgs",
                        PlayerAge = 32,
                        TeamName = "Arsenal",
                        NumberOfFans = 1565,
                         AddComments = "",
              },
                          new Player{ PlayerId = 37,
                        PlayerName = "Zoevy",
                        PlayerAge = 30,
                        TeamName = "Arsenal",
                        NumberOfFans = 456,
                         AddComments = "",
              },
                            new Player{ PlayerId = 38,
                        PlayerName = "Taary",
                        PlayerAge = 32,
                        TeamName = "Arsenal",
                        NumberOfFans = 150,
                         AddComments = "",
              },
                              new Player{ PlayerId = 39,
                        PlayerName = "Mic",
                        PlayerAge = 28,
                        TeamName = "Arsenal",
                        NumberOfFans = 290,
                         AddComments = "",
              },
                                new Player{ PlayerId = 40,
                        PlayerName = "Cristy",
                        PlayerAge = 27,
                        TeamName = "Arsenal",
                        NumberOfFans = 1380,
                         AddComments = "",
              },
                                  new Player{ PlayerId = 41,
                        PlayerName = "Poppy",
                        PlayerAge = 29,
                        TeamName = "Aston Villa",
                        NumberOfFans = 600,
                         AddComments = "",
              },
                          new Player{ PlayerId = 42,
                        PlayerName = "Haary",
                        PlayerAge = 30,
                        TeamName = "Aston Villa",
                        NumberOfFans = 900,
                         AddComments = "",
              },
                            new Player{ PlayerId = 43,
                        PlayerName = "Zome",
                        PlayerAge = 17,
                        TeamName = "Aston Villa",
                        NumberOfFans = 600,
                         AddComments = "",
              },
                              new Player{ PlayerId = 44,
                        PlayerName = "Aame",
                        PlayerAge = 18,
                        TeamName ="Aston Villa",
                        NumberOfFans = 900,
                         AddComments = "",
              },
                                new Player{ PlayerId = 45,
                        PlayerName = "Popz",
                        PlayerAge = 20,
                        TeamName = "Aston Villa",
                        NumberOfFans = 890,
                         AddComments = "",
              },
                                  new Player{ PlayerId = 46,
                        PlayerName = "Maathew",
                        PlayerAge = 31,
                        TeamName = "Fulham",
                        NumberOfFans = 5800,
                         AddComments = "",
              },
                          new Player{ PlayerId = 47,
                        PlayerName = "Leo",
                        PlayerAge = 32,
                        TeamName = "Fulham",
                        NumberOfFans = 900,
                         AddComments = "",
              },
                            new Player{ PlayerId = 48,
                        PlayerName = "Papzy",
                        PlayerAge = 30,
                        TeamName ="Fulham",
                        NumberOfFans = 500,
                         AddComments = "",
              },
                              new Player{ PlayerId = 49,
                        PlayerName = "Shivangi",
                        PlayerAge = 20,
                        TeamName = "Fulham",
                        NumberOfFans = 159000,
                         AddComments = "",
              },
                         new Player{ PlayerId = 50,
                        PlayerName = "Maitri",
                        PlayerAge = 20,
                        TeamName ="Fulham",
                        NumberOfFans = 569000,
                         AddComments = "",
              },
        };
        // GET: Product
        public ActionResult Index()
        {
            return View(Players);
        }

        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            Player selectedPlayer = Players.First(p => p.PlayerId == id);

            if (selectedPlayer == null) return new HttpNotFoundResult();

            return View(selectedPlayer);
        }
        // GET: Edit/id 
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            Player selectedPlayer = Players.First(p => p.PlayerId == id);
            if (selectedPlayer == null) return new HttpNotFoundResult();
            return View(selectedPlayer);
        }
    }
}