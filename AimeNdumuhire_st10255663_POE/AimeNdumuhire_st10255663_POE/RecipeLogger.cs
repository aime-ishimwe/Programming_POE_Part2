using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimeNdumuhire_st10255663_POE
{
    internal class RecipeLogger
    {
        public Dictionary<String, RecipeManager> dictionaryRecipe;
        public RecipeLogger(Dictionary<String, RecipeManager> dictionaryRecipe)
        {
            this.dictionaryRecipe = dictionaryRecipe;   
         
        }
        
        public void logDetails()

        {
            Console.WriteLine("Enter number of recipes");
            //lets user enter how many recipes will be entered into the app
            int recipeNum;
            if (int.TryParse(Console.ReadLine(), out recipeNum))
            {
                for (int i = 0; i < recipeNum; i++)
                {
                    Console.WriteLine("Enter recipe name ");
                    string recipeName = Console.ReadLine();
                    RecipeManager recipe = new RecipeManager();
                    recipe.EnterRecipeDetails();
                    dictionaryRecipe.Add(recipeName, recipe);

                }

                //lets user see ingridients and recipes if they would like to
                String ans;
                do {
                    Console.WriteLine("Display ingridients and steps? (Y/N)");
                        ans = Console.ReadLine();
                    switch (ans)
                    {
                        case "Y":
                            foreach(var recipeEntry in dictionaryRecipe)
                            {
                                Console.WriteLine($"Recipe Name: {recipeEntry.Key}");
                                recipeEntry.Value.DisplayRecipe();
                            }break;
                            case "N":
                            Appmenu menu = new Appmenu(dictionaryRecipe);
                            menu.appMenu();
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input");
                            break;
                    }
                } while (ans !="N");
            }
            else
            {
                Console.WriteLine("Please enter a number");
            }
        }

        //method to display recipes
        public void recipelist()
        {
            foreach(var recipeEntry in dictionaryRecipe)
            {
                Console.WriteLine($"Recipe Name:{recipeEntry.Key} ");
            }
        }
        //method to find recipes
        public void recipeFinder()
        {
            Console.WriteLine("Please enter the name of the recipe");
            string recipeName = Console.ReadLine();
            if (dictionaryRecipe.ContainsKey(recipeName))
            {
                Console.WriteLine($"Recipe Name:{recipeName} ");
                dictionaryRecipe[recipeName].DisplayRecipe();
            }
            else
            {
                Console.WriteLine("Recipe does not exist");
            }
        }

    }
}
