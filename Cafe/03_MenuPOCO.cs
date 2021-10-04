using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class Menu
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public List<String> MealIngredients { get; set; }
        public double MealPrice { get; set; }
        public Menu() { }

        public Menu(int mealNumber, string mealName, string mealDescription, List<String> mealIngredients, double mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealName;
            MealIngredients = mealIngredients;
            MealPrice = mealPrice;
        }
    }
}
