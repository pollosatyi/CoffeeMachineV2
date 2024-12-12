using CoffeeMachineSolutionV2.CoffeeComponents;

namespace CoffeeMachineSolutionV2.Coffees;

public class Capuccino : Coffee
{
    public override string Name { get; set; }="Capuccino";
    public override CoffeeBeans Beans { get; set; }
    public Milk Milk { get; set;}

    public Capuccino(CoffeeBeans beans, Milk milk)
    {
        Beans = beans;
        Milk = milk;
    }
    
    public override void MakeCoffee()
    {
        Console.WriteLine($"Кофе {Name} готовится");
    }
}