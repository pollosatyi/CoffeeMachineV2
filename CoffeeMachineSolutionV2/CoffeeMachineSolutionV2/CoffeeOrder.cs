using CoffeeMachineSolutionV2.Coffees;

namespace CoffeeMachineSolutionV2;

public class CoffeeOrder
{
   public static void CoffeeOrderPrint(List<Coffee> coffees)
   {
       if (coffees.Count==0) return;
        Console.WriteLine("Заказ: ");
        foreach (var coffee in coffees)
        {
            Console.WriteLine($"Кофе: {coffee.Name} готов");
        }
        
   }
}