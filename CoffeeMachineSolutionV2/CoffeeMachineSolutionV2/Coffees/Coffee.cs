using CoffeeMachineSolutionV2.CoffeeComponents;

namespace CoffeeMachineSolutionV2.Coffees;

public abstract class Coffee
{
    public abstract string Name { get; set; }
    public abstract CoffeeBeans Beans { get; set; }

    public abstract void MakeCoffee();

}