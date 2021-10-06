using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goldbadge_Final_Project
{
    public class Claims
    {
        public string ClaimID { get; set; }
        public ClaimTypeEnum TypeOfClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid 
        {
            get
            {
                TimeSpan value = DateOfClaim.Subtract(DateOfIncident);
                if(value.TotalDays <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Claims() { }
        public Claims(string claimID, ClaimTypeEnum claimType, string description,
            double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }
    }
        public enum ClaimTypeEnum
        {
            Car = 1,
            House,
            Theft,
            Other
        }
}
