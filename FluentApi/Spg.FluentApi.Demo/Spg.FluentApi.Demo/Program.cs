// Build a tasty Burger

using Spg.FluentApi.Demo.Interfaces;
using Spg.FluentApi.Demo.Model;
using Spg.FluentApi.Demo.Services;

IBurgerResult myBurger = new BurgerConfigurator()
    .AddPetty()
    .AddSalad(Salads.Eisberg)
    .AddCheese()
    .AddCheese()
    .AddPetty()
    .AddPetty()
    .AddPetty()
    .AddSouce(Souces.Catsup)
    .BuildBurger()
        .Additions
            .AddPommes()
            .AddDrink()
            .AddDrink()
            .AddDrink()
            .AddDrink()
            .BuildLunch();

Console.WriteLine($"{myBurger.Price} EUR");
Console.WriteLine($"{myBurger.Weight * 10} Gramm");
Console.WriteLine($"{myBurger.Calories} Kilokalorien");
