using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimeNdumuhire_st10255663_POE
{
    internal class IngredientsMenu
    {
        private Dictionary<string, RecipeManager> dictionaryRecipe;
        public IngredientsMenu(Dictionary<string, RecipeManager> dictionaryRecipe)
        {
            this.dictionaryRecipe = dictionaryRecipe;
            RecipeManager recipeManager = new
                    RecipeManager();
            bool exit = false;
            while (!exit)
            {
                // Display menu options
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("1.Enter recipe ");
                Console.WriteLine("2.Display recipe ");
                Console.WriteLine("3.Scale Recipe ");
                Console.WriteLine("4.Reset quantities ");
                Console.WriteLine("5.Clear all data ");
                Console.WriteLine("6.Go back to menu");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                // Get user choice
                string choice = Console.ReadLine();
                Console.WriteLine();

                // Perform action based on user 
                switch (choice)
                {
                    case "1":
                        recipeManager.EnterRecipeDetails();
                        break;
                    case "2":
                        recipeManager.DisplayRecipe();
                        break;
                    case "3":
                        recipeManager.ScaleRecipe();
                        break;
                    case "4":
                        recipeManager.ResetQuantities();
                        break;
                    case "5":
                        recipeManager.ClearData();
                        break;
                    case "6":
                        Appmenu appMenu = new Appmenu(dictionaryRecipe);
                        appMenu.appMenu();
                        break;
                    default:

                        Console.WriteLine("Invalid Choice. Please try again");
                        Console.WriteLine();
                        break;



                }



            }
        } 
    }
}
