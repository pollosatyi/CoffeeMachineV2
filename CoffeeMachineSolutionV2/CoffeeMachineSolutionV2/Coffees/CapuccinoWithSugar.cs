using CoffeeMachineSolutionV2.CoffeeComponents;

namespace CoffeeMachineSolutionV2.Coffees;

public class CapuccinoWithSugar : Coffee
{
    public override string Name { get; set; }="Capuccino With Sugar";
    public override CoffeeBeans Beans { get; set; }
    public Milk Milk { get; set; }
    public Sugar Sugar { get; set; }

    public CapuccinoWithSugar(CoffeeBeans beans, Milk milk, Sugar sugar)
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