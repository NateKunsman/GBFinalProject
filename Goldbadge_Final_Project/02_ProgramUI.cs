using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goldbadge_Final_Project
{
    class ProgramUI
    {
        private _04_ClaimsRepository _claimsRepo = new _04_ClaimsRepository();
        public void Run()
        {
            //Main Menu
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Hello, Agent! What would you like to do?\n" +
                    "****************************************\n" +
                    "1.See all claims\n" +
                    "2.Take care of next claim\n" +
                    "3.Enter a new claim\n" +
                    "4.Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //List all claims
                        ShowAllClaims();
                        break;
                    case "2":
                        //Take care of next claim
                        ProcessNextClaim();
                        break;
                    case "3":
                        //Enter a new claim
                        CreatNewClaim();
                        break;
                    case "4":
                        //Exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Entera valid number and press any key to continue");
                        Console.ReadLine();
                        Console.ReadKey();
                        break;
                }
            }
        }
        //Shows a list of all claims
        private void ShowAllClaims()
        {
            Console.Clear();
            Queue<Claims> listOfClaims = _claimsRepo.ShowAllClaims();
            int startingCount = 0;

            foreach(Claims content in listOfClaims)
            {
                startingCount++;
                Console.WriteLine(
                    "ClaimID | Type | Description | Claim Amount | Date of Incident | Date of Claim | Valid");
                Console.WriteLine(
                    "_______________________________________________________________________________________");
                Console.WriteLine(
                    content.ClaimID + " " + content.TypeOfClaim + " " + content.Description + " " + content.ClaimAmount + " " + content.DateOfIncident + " " +
                    content.DateOfClaim + " " + content.IsValid + "\n\n");
            }
            if(startingCount == 0)
            {
                Console.WriteLine("There are no claims at this time");
            }

            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
        }
        //Take care of next claim
        private void ProcessNextClaim()
        {
            Console.Clear();
            Claims nextClaim = new Claims();
            nextClaim = _claimsRepo.PullTopClaim();
            if (nextClaim == null)
            {
                Console.WriteLine("There are no claim to be found");
            }
            else
            {
                Console.WriteLine("Claim ID:" + nextClaim.ClaimID);
                Console.WriteLine("Claim Type:" + nextClaim.TypeOfClaim);
                Console.WriteLine("Description:" + nextClaim.Description);
                Console.WriteLine("Claim Amount:" + nextClaim.ClaimID);
                Console.WriteLine("Date of incident:" + nextClaim.DateOfIncident);
                Console.WriteLine("Date of claim:" + nextClaim.DateOfClaim);
                Console.WriteLine("Claim valid:" + nextClaim.ClaimID + "\n\n");

                Console.WriteLine("Would you like to mark this claim finished? y/n\n" +
                    "If you mark yes, this claim will be removed\n" +
                    "If you mark no, this claim will remain");

                bool isRunning = true;
                while (isRunning)
                {
                    string input = Console.ReadLine();
                    switch (input.ToLower())
                    {
                        case "y":
                            bool wasRemoved = _claimsRepo.RemoveTopClaim();
                            if (wasRemoved)
                            {
                                Console.WriteLine("This claim was succesfully removed");
                            }
                            isRunning = false;
                            break;
                        case "n":
                            Console.WriteLine("This claim will not be removed");
                            isRunning = false;
                            break;
                        default:
                            {
                                Console.WriteLine("Please enter a valid menu option 'y' or 'n' ");
                            }
                            break;
                    }
                }
            }
        }
        //Creat a new claim
        private void CreatNewClaim()
        {
            Console.Clear();
            Claims content = new Claims();

            //ClaimID
            Console.WriteLine("Please enter the claim ID");
            content.ClaimID = Console.ReadLine();
            //Claim Type
            Console.WriteLine("Please select a claim type\n" +
                "1.Car\n" +
                "2.Home\n" +
                "3.Theft\n" +
                "4.Other");

            string claimType = Console.ReadLine();
            int typeOfClaim = int.Parse(claimType);
            content.TypeOfClaim = (ClaimTypeEnum)typeOfClaim; 
            //Description
            Console.WriteLine("Please enter a description of the claim");
            content.Description = Console.ReadLine();
            //Claim Amount
            Console.WriteLine("Please enter the amount of the claim");
            content.ClaimAmount = double.Parse(Console.ReadLine());
            //Date of incident
            Console.WriteLine("Please enter the date of the incident\n" +
                "Example: 05/12/2021");
            content.DateOfIncident = DateTime.Parse(Console.ReadLine());
            //Date of claim
            Console.WriteLine("Please enter the date the claim was made");
            content.DateOfClaim = DateTime.Parse(Console.ReadLine());
        }
        //Helper method
        private void DisplayClaim(Claims claim)
        {
            Console.WriteLine(
                $"ClaimID: { claim.ClaimID}\n" +
                $"Claim Type: { claim.TypeOfClaim}\n" +
                $"Description: { claim.Description}\n" +
                $"Claim Amount: { claim.ClaimAmount}\n" +
                $"Date of incident:{ claim.DateOfIncident}\n" +
                $"Date of claim: { claim.DateOfClaim}\n" +
                $"Valid: { claim.IsValid}"
                );
        }
        //Seed Data
    }
}
