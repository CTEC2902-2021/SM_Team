using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Football.Controllers;

namespace Football.Models
{
    public class Club
    {
        public int ClubId { get; set; }

        [Required]
        public string ClubName { get; set; }

        [StringLength(100)]

        public string ClubDescription { get; set; }

        public List<Player> Players { get; set; }
        public string PlayerName { get; set; }
    }
}