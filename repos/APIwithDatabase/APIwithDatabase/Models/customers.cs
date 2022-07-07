using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIwithDatabase.Models
{
    public class customers
    {
        public int Custimer_id { get; set; }

        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Mobileno { get; set; }

        public string Createdat { get; set; }

    }
}