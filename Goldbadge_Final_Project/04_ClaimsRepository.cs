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
        private readonly Queue<Claims> _claimsQueue = new Queue<Claims>();
        //Menu Items:
        //1.See all claims //Read method
        public Queue<Claims> ShowAllClaims()
        {
            return _claimsQueue;
        }

        //2.Take care of next claim //A queue kind of method????
        //Use Peek() or use Dequeue()?
        
        public Claims PullTopClaim()  //Method to view first in queue
        {
            if (_claimsQueue.Count == 0)
            {
                return null;
            }
            else
            {
                return _claimsQueue.Peek();
            }
        }
        //Method to deal with next claim
        public bool RemoveTopClaim()
        {
            int startingCount = _claimsQueue.Count;
            _claimsQueue.Dequeue();
            bool wasRemoved = _claimsQueue.Count < startingCount;
            return wasRemoved;
        }

        //3.Enter a new claim //Essentially a create method
        public bool CreateNewClaim(Claims contentOfClaim)
        {
            int startingCount = _claimsQueue.Count;
            _claimsQueue.Enqueue(contentOfClaim);
            bool wasCreated = _claimsQueue.Count > startingCount;
            return wasCreated;
        }
    }
}
