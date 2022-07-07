using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppl_todo.Models
{
    public class List
    {
        public int id { get; set; }
        public string title { get; set; }
        public int time_spend { get; set; }
        public DateTime created_at { get; set; }
    }
}
