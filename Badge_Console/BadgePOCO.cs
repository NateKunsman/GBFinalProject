using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Console
{
    public class Badges
    {
        public Badges() { }
        public Badges(List<string> doorName)
        {
            DoorName = doorName;
        }
        public int BadgeID { get; set; }
        public List<string> DoorName { get; set; }
    }
}
