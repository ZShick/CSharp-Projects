using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step324
{
    //created a class for Day including the DayName
    public class Day
    {
        public DayName DayName { get; set; }
    }
    //DayName is a custom Enum
    public enum DayName
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
