using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Project_Ex.Models
{
    public class Loptops
    {
        public int LopId { get; set; }
        public string lopname { get; set; }

        public string LopModel { get; set; }

        public string LopDetails { get; set; }

        public int Lopprice { get; set; }

        public string LopUrl { get; set; }
    }
}