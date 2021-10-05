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
            SeedData();
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
                Console.WriteLine("Please press any key to return to menu");
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
            menu.MealNumber = Console.ReadLine();
            //MealName
            Console.WriteLine("Enter the name of this meal");
            menu.MealName = Console.ReadLine();
            //MealDesciption
            Console.WriteLine("Enter a description for this meal");
            menu.MealDescription = Console.ReadLine();
            //MealIngredients
            Console.WriteLine("Enter ingredients for this meal\n" +
                "Please type each ingredient followed by a comma.\n" +
                "Example: cheese, lettuce, tomato");
            string mealIngredients = Console.ReadLine();
            //menu.MealIngredients = mealIngredients.Split(','); *****SEE IF YOU CAN GET THIS WORKING AS A STRING ARRAY****
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
            ShowAllMenuItems();

            //Get the Menu Item User wants to delete
            Console.WriteLine("Enter the menu number of the meal you would like to delete");
            string input = Console.ReadLine();
            //Call the Delete method
            bool wasDeleted = _repo.DeleteMenuItem(_repo.GetMenuItemByNumber(input));
            //if the content was deleted, say so
            if (wasDeleted)
            {
                Console.WriteLine("The meal was succesfully deleted");
            }
            else
            {
                Console.WriteLine("Meal number not found and therefore could not be deleted");
            }
            //Otherwise state it could not be deleted

        }



        //Helper Methods
        private void SeedData()
        {
            Menu blackBeanBurger = new Menu("#1", "Black Bean Burger",
                "blah blah yum, blah blah comes with side", "black beans, onions, lettuce, tomato", 11.95);
            Menu marshmelloSliders = new Menu("#2", "Marshmellow Sliders",
                 "blah blah 3 sliders(you can mix and match), blah blah comes with side", "ing1, ing2, ing3, ing4", 7.95);
            Menu cowboyBurger = new Menu("#3", "Cowboy Burger",
                "blah blah yum, blah blah comes with side", "peanut butter, ing7, ing11, ing2", 9.95);

            _repo.CreatNewMenuItem(blackBeanBurger);
            _repo.CreatNewMenuItem(cowboyBurger);
            _repo.CreatNewMenuItem(marshmelloSliders);
        }
    }
}
