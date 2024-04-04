using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocktaillist
{
    public class CLib
    {
        public void ShowHistory(Calbum cocktail)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Here's your Drink!");
            Console.WriteLine(cocktail.cname);
            Console.WriteLine(cocktail.mainingredients);
            Console.WriteLine(cocktail.prep);
            Console.WriteLine(cocktail.flavor);
            Console.WriteLine(cocktail.type1);
            Console.WriteLine(cocktail.type2);
            Console.WriteLine("-----------------------");

        }

    }
}
