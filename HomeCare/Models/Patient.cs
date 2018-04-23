using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeCare.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public String UserType { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public String Handicap { get; set; }
        public String BloodType { get; set; }
        public String Illneses { get; set; }


    }
}