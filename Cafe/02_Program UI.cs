using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class Program_UI
    {
        private MenuRepository _repo = new MenuRepository();
        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            //Create a menu with options matching up to the MenuRepository
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the number of your selection:\n" +
                    "1. Create new menu item\n" +
                    "2. Show all menu items\n" +
                    "3. Delete Menu Item\n" +
                    "4. Exit");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //Create new menu item
                        CreatNewMenuItem();
                        break;
                    case "2":
                        //Show all menu items
                        ShowAllMenuItems();
                        break;
                    case "3":
                        //Delete Menu Item
                        DeleteMenuItem();
                        break;
                    case "4":
                        //Exit
                        isRunning = false;
                        break;
                }
            }
        }
        //Create Item
        private void CreateNewMenuItem()
        {
            Console.Clear();
            Menu menu = new Menu();
            //MealNumber
            Console.WriteLine("Please enter the number this menu item will be refered to by");
            menu.MealNumber = Console.ReadLine();
            //MealName
            //MealDesciption
            //MealIngredients
            //MealPrice
        }
    }
}
