using CoffeeMachineSolutionV2.CoffeeComponents;

namespace CoffeeMachineSolutionV2.Coffees;

public class BlackWithSugar : Coffee
{
    public override string Name { get; set; } = "Black With Sugar";
    public override CoffeeBeans Beans { get; set; }
    public Sugar Sugar { get; set; } 
    
    public BlackWithSugar(CoffeeBeans beans, Sugar sugar)
    {
        Beans = beans;
        Sugar = sugar;
    }
    
    public override void MakeCoffee()
    {
        Console.WriteLine($"Кофе {Name} готовится");
    }
}