using System.Diagnostics;

namespace CoffeeMachineSolutionV2;

public class CoffeeMenu
{
    public static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("Кофемашина готова к работе");
            Console.WriteLine("Выберите пункт меню: ");
            int countOfTypeCoffee = 5;
            PrintCoffeeType(countOfTypeCoffee);
            Console.WriteLine("0 - для выхода");
            string inputMenu = Console.ReadLine();
            bool isNumber = int.TryParse(inputMenu, out int selectedNumber);
            if (!isNumber)
            {

                Console.WriteLine("Неправильный ввод. Это не число");
                continue;
            }

            if (selectedNumber == 0)
            {
                Console.WriteLine("Программа завершена ");
                break;
            }

            if (selectedNumber < 1 || selectedNumber > 5)
            {

                  Console.WriteLine("Кофе с таким номером нет");
                continue;
            }
            
        }
    }

    
    private static void PrintCoffeeType(int countOfTypeCoffee)
    {
        for (int i = 1; i <= countOfTypeCoffee; i++)
        {
            var coffeeType = (CoffeeType)i;
            string nameOfTypeCoffee = NameOfTypeCoffee(coffeeType );
            Console.WriteLine($"{i} - для заказа кофе {nameOfTypeCoffee}");
        }
        
    }

    private static string NameOfTypeCoffee(CoffeeType coffeeType)
    {
        string nameOfTypeCoffee = coffeeType switch
        {
            CoffeeType.BlackCoffee => "BlackCoffee",
            CoffeeType.BlackWithSugar => "BlackWithSugar",
            CoffeeType.Capuccino => "Capuccino",
            CoffeeType.CapuccinoWithSugar=> "CapuccinoWithSugar",
            CoffeeType.Latte => "Latte"

        };
        return nameOfTypeCoffee;

    }
}