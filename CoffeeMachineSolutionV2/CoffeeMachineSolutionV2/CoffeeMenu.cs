using System.Diagnostics;
using CoffeeMachineSolutionV2.Coffees;

namespace CoffeeMachineSolutionV2;

public class CoffeeMenu
{
    public static void ShowMenu()
    {
        
        
            Console.WriteLine("Кофемашина готова к работе");
            Console.WriteLine("Выберите пункт меню: ");
            int countOfTypeCoffee = 5;
            PrintCoffeeType(countOfTypeCoffee);
            Console.WriteLine("0 - для выхода");
            
       
    }

    
    private static void PrintCoffeeType(int countOfTypeCoffee)
    {
        for (int i = 1; i <= countOfTypeCoffee; i++)
        {
            var coffeeType = (CoffeeType)i;
            string nameOfTypeCoffee = CoffeeTypeName.NameOfTypeCoffee(coffeeType );
            Console.WriteLine($"{i} - для заказа кофе {nameOfTypeCoffee}");
        }
        
    }

    
}