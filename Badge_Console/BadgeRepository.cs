using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Console
{
    class BadgeRepository
    {
        private readonly Dictionary<int,Badges> _badgesDictionary = new Dictionary<int, Badges>();
        //Add a badge
        public bool AddANewBadgeToDirectory(Badges data)
        {
            int startingCount = _badgesDictionary.Count;
            _badgesDictionary.Add(data.BadgeID, data);
            bool wasAdded = (_badgesDictionary.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //List all badges
        public Dictionary<int, Badges> ListAllBadges()
        {
            return _badgesDictionary;
        }
        //Search for a specific badge
        public Badges SearchForSpecificBadge(int badgeID)
        {
            foreach (var badgeInfo in _badgesDictionary)
            {
                if(badgeInfo.Key == badgeID)
                {
                    return badgeInfo.Value;
                }
            }
            return null;
        }

        //Edit a badge
        public bool EditExistingBadgeByID(Badges existingBadge, Badges newBadge)
        {
            if (existingBadge != null)
            {
                existingBadge.BadgeID = newBadge.BadgeID;
                existingBadge.DoorName = newBadge.DoorName;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete door(s) from badge
        public bool DeleteDoorsFromBadge(int badgeID, string doorName)
        {
            Badges badgeData = SearchForSpecificBadge(badgeID);
            bool result = badgeData.DoorName.Remove(doorName);
            return result;
        }
    }
}
