
﻿using CoffeeMachineSolutionV2.Coffees;

namespace CoffeeMachineSolutionV2;



class Program
{
    static void Main(string[] args)
    {

        var orderOfCoffee=CoffeeCreate.CreateCoffee();
        CoffeeOrder.CoffeeOrderPrint(orderOfCoffee);
    }
}