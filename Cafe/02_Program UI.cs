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
        // public void Run() is a method that runs/starts the application
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
                //Display options to the user
                Console.WriteLine(
                    "Enter the number of your selection:\n" +
                    "1. Create new menu item\n" +
                    "2. Show all menu items\n" +
                    "3. Delete Menu Item\n" +
                    "4. Exit");
                //Get the users input
                string userInput = Console.ReadLine();
                //Evaluate the user's input and act accordingly
                switch (userInput)
                {
                    case "1":
                        //Create new menu item
                        CreateNewMenuItem();
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
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Create Item
        private void CreateNewMenuItem()
        {
            Console.Clear();
            Menu menu = new Menu();
            //MealNumber
            Console.WriteLine("Enter the number this menu item will be refered to by");
            menu.MealNumber = int.Parse(Console.ReadLine());
            //MealName
            Console.WriteLine("Endter the name of this meal");
            menu.MealName = Console.ReadLine();
            //MealDesciption
            Console.WriteLine("Enter a description for this meal");
            menu.MealDescription = Console.ReadLine();
            //MealIngredients
            Console.WriteLine("Enter ingredients for this meal\n" +
                "Please type each ingredient followed by a comma.\n" +
                "Example: cheese, lettuce, tomato");
            string mealIngredients = Console.ReadLine();
            menu.MealIngredients = mealIngredients.Split(',').ToList);
            //MealPrice
            Console.WriteLine("Enter price for this meal");
           menu.MealPrice = double.Parse(Console.ReadLine());

            _repo.CreatNewMenuItem(menu);
            

        }
        //Show all Menu Items
        private void ShowAllMenuItems()
        {
            List<Menu> listOfMenuItems = _repo.ShowMenuItems();
            foreach(Menu menu in listOfMenuItems)
            {
                Console.WriteLine($"Meal Number: {menu.MealNumber}\n," +
                    $" Meal Name: {menu.MealName}\n," +
                    $" Description: {menu.MealDescription}\n," +
                    $" Ingredients: {menu.MealIngredients}," +
                    $" Price: {menu.MealPrice}");
            }
        }
        //Delete Menu Items
        private void DeleteMenuItem()
        {

        }



        //Helper Methods
        private void SeedData()
        {
            Menu blackBeanBurger = new Menu("#1", "Black Bean Burger\n" +
                "blah blah yum, blah blah comes with side", "black beans, onions, lettuce, tomato", 8.99);

            _repo.CreatNewMenuItem(blackBeanBurger);
        }
    }
}
