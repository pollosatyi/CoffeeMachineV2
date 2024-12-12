namespace CoffeeMachineSolutionV2;

public class CoffeeTypeName
{
    public static string NameOfTypeCoffee(CoffeeType coffeeType)
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