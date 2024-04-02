using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Entity
{
    public class Score
    {
        //Sql-de yaradacagmiz tabledir..burday yaradib ora gonderirik
        public int ID { get; set; }
        public string? Home { get; set; }
        public string? Away { get; set; }
        public string? ScoreNumber { get; set; }
        public DateTime Date { get; set; }
    }
}
