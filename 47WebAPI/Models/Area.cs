using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _47WebAPI.Models
{
    public class Areas
    {
        public int ID { get; set; }
        public int ZoneID { get; set; }
        public string  Area { get; set; }
        public string AreaCode { get; set; }
    }
    public  class Zones
    {
        public int ID { get; set; }
        public string Zone { get; set; }

        public List<Areas> Areas { get; set; }
    }
}