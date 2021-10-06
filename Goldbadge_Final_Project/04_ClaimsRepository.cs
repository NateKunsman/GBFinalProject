using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goldbadge_Final_Project
{
    class _04_ClaimsRepository
    {
        //Feild
        private readonly Queue<Claims> _claimsDirectory = new Queue<Claims>();
        //Menu Items:
        //1.See all claims //Read method
        public Queue<Claims> ShowAllClaims()
        {
            return _claimsDirectory;
        }

        //2.Take care of next claim //A queue kind of method????
        //Use Peek() or use Dequeue()?
        //Method to view first in queue
        public Claims PullTopClaim()
        {
            return _claimsDirectory.Peek();
        }
        //Method to deal with next claim
        public bool RemoveTopClaim()
        {
            int startingCount = _claimsDirectory.Count;
            _claimsDirectory.Dequeue();
            bool wasRemoved = _claimsDirectory.Count < startingCount;
            return wasRemoved;
        }

        //3.Enter a new claim //Essentially a create method
        public bool CreateNewClaim(Claims contentOfClaim)
        {
            int startingCount = _claimsDirectory.Count;
            _claimsDirectory.Enqueue(contentOfClaim);
            bool wasCreated = _claimsDirectory.Count > startingCount;
            return wasCreated;
        }
    }
}
