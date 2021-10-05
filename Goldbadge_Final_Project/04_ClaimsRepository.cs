using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goldbadge_Final_Project
{
    class _04_ClaimsRepository
    {
        private readonly List<Claims> _claimsDirectory = new List<Claims>();
        //Menu Items:
        //1.See all claims //Read method
        public List<Claims> ShowAllClaims()
        {
            return _claimsDirectory;
        }

        //2.Take care of next claim //a queu kind of method????


        //3.Enter a new claim //Essentially a create method
        public bool CreateNewClaim(Claims claims)
        {
            int startingCount = _claimsDirectory.Count;
            _claimsDirectory.Add(claims);
            bool wasCreated = (_claimsDirectory.Count > startingCount) ? true : false;
            return wasCreated;
        }
    }
}
