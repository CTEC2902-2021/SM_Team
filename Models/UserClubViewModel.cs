using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace Football.Models
{
    public class UserClubViewModel
    {
        public Club Club { get; set; }
        public User User { get; set; }
    }

}