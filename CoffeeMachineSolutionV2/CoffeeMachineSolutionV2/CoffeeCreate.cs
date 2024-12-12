using System.Net;
using CoffeeMachineSolutionV2.CoffeeComponents;
using CoffeeMachineSolutionV2.Coffees;

namespace CoffeeMachineSolutionV2;

public class CoffeeCreate
{
    public static List<Coffee> CreateCoffee()
    {
        List<Coffee> coffeeList = new List<Coffee>();
        CoffeeBeans coffeeBeans = new CoffeeBeans();
        Milk milk = new Milk();
        Sugar sugar = new Sugar();
        while (true)
        {
            CoffeeMenu.ShowMenu();
            string inputMenu = Console.ReadLine();
            bool isNumber = int.TryParse(inputMenu, out int selectedNumber);
            if (!isNumber)
            {
                Console.WriteLine("Неправильный ввод. Это не число");
                continue;
            }

            if (selectedNumber == 0)
            {
                Console.WriteLine("Добавление кофе завершено ");
                break;
            }

            if (selectedNumber < 1 || selectedNumber > 5)
            {
                Console.WriteLine("Кофе с таким номером нет");
                continue;
            }
            Coffee coffee = (CoffeeType)selectedNumber switch
            {
                CoffeeType.BlackCoffee => new BlackCoffee(coffeeBeans),
                CoffeeType.BlackWithSugar => new BlackWithSugar(coffeeBeans,sugar),
                CoffeeType.Capuccino => new Capuccino(coffeeBeans,milk),
                CoffeeType.CapuccinoWithSugar => new CapuccinoWithSugar(coffeeBeans,milk, sugar),
                CoffeeType.Latte => new Latte(coffeeBeans,milk,sugar),
                _=>throw new NotImplementedException()
            };
            PrintMake(coffee);
            coffeeList.Add(coffee);
        }
        return coffeeList;
    }

    private static void PrintMake(Coffee coffee)
    {
        coffee.MakeCoffee();
    }
}