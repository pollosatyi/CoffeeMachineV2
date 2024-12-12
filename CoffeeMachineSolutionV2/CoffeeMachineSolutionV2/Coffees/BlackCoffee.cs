using CoffeeMachineSolutionV2.CoffeeComponents;

namespace CoffeeMachineSolutionV2.Coffees;

public class BlackCoffee: Coffee
{
    public override string Name { get; set; }="Black Coffee";
    public CoffeeBeans Beans { get; set; }

    public BlackCoffee(CoffeeBeans beans)
    {
        Beans = beans;
    }

    
   
}