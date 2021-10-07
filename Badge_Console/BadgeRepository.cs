using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Console
{
    class BadgeRepository
    {
        private readonly Dictionary<int, List<string>> _badgesRepo = new Dictionary<int, List<string>> { };
        //Add a badge
        public bool AddANewBadgeToDirectory(Badges newBadge)
        {
            int startingCount = _badgesRepo.Count;
            _badgesRepo.Add(newBadge.BadgeID, newBadge.DoorName);
            bool wasAdded = (_badgesRepo.Count > startingCount);
            return wasAdded;
        }
        //List all badges
        public List<int> DisplayAllBadges()
        {
            return _badgesRepo;
        }
        //Search for a specific badge
        public Badges SearchForSpecificBadge(int badgeID)
        {
            foreach (var badgeInfo in _badgesRepo)
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
