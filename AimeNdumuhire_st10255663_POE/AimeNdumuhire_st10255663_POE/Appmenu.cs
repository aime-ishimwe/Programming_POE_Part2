using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimeNdumuhire_st10255663_POE
{
    internal class Appmenu
    {
        public Dictionary<String, RecipeManager> dictionaryRecipe;
        public RecipeLogger recipeLogger;
        public Appmenu(Dictionary<String, RecipeManager> dictionaryRecipe)
        {
            this.dictionaryRecipe = dictionaryRecipe;
            recipeLogger = new RecipeLogger(dictionaryRecipe);

        }
        public void appMenu()
        {
            while(true)
            {
                //the menu that is shown when the application is open
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("=============================================================================");
                Console.WriteLine("RECIPE APP");
                Console.WriteLine("=============================================================================");
                Console.WriteLine("1.Create recipe ");
                Console.WriteLine("2.Search for recipe ");
                Console.WriteLine("3.Display all Recipe ");
                Console.WriteLine("4.Exit application");
                Console.WriteLine("=============================================================================");
                Console.WriteLine("Please select a option");
                string ans = Console.ReadLine();
                switch(ans)
                {
                    case "1":
                        recipeLogger.logDetails();
                        break;
                        case "2":
                        recipeLogger.recipeFinder();
                        break;
                        case "3":
                        recipeLogger.recipelist();
                        break;
                        case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter valid input");
                        break;

                }
            }

        }
    }
}
