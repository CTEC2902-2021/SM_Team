using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Football.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerAge { get; set; }
        public string TeamName { get; set; }
        public int NumberOfFans { get; set; }

        public string AddComments{ get; set; }
    }
}