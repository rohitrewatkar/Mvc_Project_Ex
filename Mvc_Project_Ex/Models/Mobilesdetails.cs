using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Project_Ex.Models
{
    public class Mobilesdetails
    {
        public int MobId { get; set; }
        public string Mobname { get; set; }

        public double price { get; set; }

        public string Features { get; set; }

        public int Models { get; set; }

        public string Colors { get; set; }

        public string Sim_type { get; set; }

        public string Url { get; set; }
    }
}