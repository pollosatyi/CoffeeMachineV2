using CoffeeMachineSolutionV2.CoffeeComponents;

namespace CoffeeMachineSolutionV2.Coffees;

public class Latte : Coffee
{
    public override string Name { get; set; }="Latte";
    public override CoffeeBeans Beans { get; set; }
    public Milk Milk { get; set; }
    public Sugar Sugar { get; set; }

    public Latte(CoffeeBeans beans, Milk milk, Sugar sugar)
    {
        Beans = beans;
        Milk = milk;
        Sugar = sugar;
    }
    public override void MakeCoffee()
    {
        Console.WriteLine($"Кофе {Name} готовится");
    }
}