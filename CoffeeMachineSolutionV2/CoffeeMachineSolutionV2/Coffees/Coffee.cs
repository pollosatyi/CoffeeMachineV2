namespace CoffeeMachineSolutionV2.Coffees;

public abstract class Coffee
{
    public abstract string Name { get; set; }

    public  void MakeCoffee()
    {
        Console.WriteLine($" Кофе {Name} готов");
    }
}