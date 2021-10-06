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
                        break;
                    case "2":
                        //Take care of next claim
                        break;
                    case "3":
                        //Enter a new claim
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
        //List all claims
        private void ShowAllClaims()
        {
            Console.Clear();
            Queue<Claims> listOfClaims = _claimsRepo.ShowAllClaims();

            foreach(Claims content in listOfClaims)
            {
                DisplayClaim(content);
            }

            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
        }
        //Take care of next claim
        private void ProcessNextClaim()
        {

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
