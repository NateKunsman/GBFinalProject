using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Console
{
    class BadgeRepository
    {
        private readonly Dictionary<int, Badges> _badgesRepo = new Dictionary<int, Badges>();
        //Add a badge
        public bool AddANewBadgeToDirectory(Badges newBadge)
        {
            int startingCount = _badgesRepo.Count;
            _badgesRepo.Add(newBadge.BadgeID, newBadge);
            bool wasAdded = (_badgesRepo.Count > startingCount);
            return wasAdded;
        }
        //List all badges
        public List<int> DisplayAllBadges()
        {
            List<int> badgesToDisplay = new List<int>();
            foreach (var pair in _badgesRepo)
            {
                badgesToDisplay.Add(pair.Key);
            }
            return badgesToDisplay;
        }
        //Search for a specific badge
        public List<string> SearchForSpecificBadge(int badgeID)
        {
            foreach (var pair in _badgesRepo)
            {
                if (pair.Key == badgeID)
                {
                    return pair.Value;
                }
            }
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
        public bool DeleteDoorsFromBadge(Badges badgeID, string doorName)
        {
            Badges badgeData = SearchForSpecificBadge(badgeID);
            bool result = badgeData.DoorName.Remove(doorName);
            return result;
        }
    }
}
