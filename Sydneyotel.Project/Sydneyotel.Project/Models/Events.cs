using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sydneyotel.Project.Models
{
    public class Events
    {
        public string EventID { get; set; }
        public string Title { get; set; }
        public string EventDescription { get; set; }
        public string Duration { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
    }
}