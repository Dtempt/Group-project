using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sydneyotel.Project.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}