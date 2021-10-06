using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Console
{
    class ProgramUI
    {
        private BadgeRepository _badgeRepo = new BadgeRepository();
        public void Run()
        {
            RunMainMenu();
        }
        private void RunMainMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Hello, Security Admin! What would you like to do?\n" +
                    "Please type the number of your selection and press enter\n\n" +
                    "1.Add a badge\n" +
                    "2.Edit a badge\n" +
                    "3.List all badges\n" +
                    "4.Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddANewBadgeToDirectory();
                        break;
                    case "2":
                        EditExistingBadgeByID();
                        break;
                    case "3":
                        ListAllBadges();
                        break;
                    case "4":
                        //Exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Press any key to return to main menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Add a badge
        private void AddANewBadgeToDirectory()
        {
            Console.Clear();
            Badges badge = new Badges();
            Console.WriteLine("Enter new badge ID");
            badge.BadgeID = int.Parse(Console.ReadLine());
            bool createNewDoor = true;
            while (createNewDoor)
            {
                Console.WriteLine("Would you like to add access to doors? y/n?");
                if (Console.ReadLine() == "y")
                {
                    List<string> doorsToAdd = new List<string>();
                    bool enterDoorID = true;
                    while (enterDoorID)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter which door(s) this badge has access to:\n" +
                            "If multiple doors please use commas to to seperate\n" +
                            "Example: A1, B5, A2");
                        doorsToAdd.Add(Console.ReadLine());
                        badge.DoorName = doorsToAdd;
                        Console.Clear();
                        Console.WriteLine("Add additional doors? y/n?");
                        if (Console.ReadLine()== "n")
                        {
                            enterDoorID = false;
                            createNewDoor = false;
                        }
                    }
                }
                else if (Console.ReadLine() == "n")
                {
                    createNewDoor = false;
                }
            }
            _badgeRepo.AddANewBadgeToDirectory(badge);
        }
        //Edit a badge
        private void EditExistingBadgeByID()
        {

        }
        //List all badges
        private void ListAllBadges()
        {

        }

        //Helper Method
    }
}
