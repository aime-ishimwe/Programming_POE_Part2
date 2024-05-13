// See https://aka.ms/new-console-template for more information
namespace AimeNdumuhire_st10255663_POE;


class Program
{
    static void Main(string[] args)
    {
        //calls the Appmenu class
         Dictionary<String, RecipeManager> dictionaryRecipe = new Dictionary<string, RecipeManager>();
         Appmenu menu = new Appmenu(dictionaryRecipe);
        menu.appMenu();

}
}
