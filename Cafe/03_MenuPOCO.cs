using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Menu
    {
        public string MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredients { get; set; }
        public double MealPrice { get; set; }
        public Menu() { }

        public Menu(string mealNumber, string mealName, string mealDescription, string mealIngredients, double mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealName;
            MealIngredients = mealIngredients;
            MealPrice = mealPrice;
        }
    }
}
