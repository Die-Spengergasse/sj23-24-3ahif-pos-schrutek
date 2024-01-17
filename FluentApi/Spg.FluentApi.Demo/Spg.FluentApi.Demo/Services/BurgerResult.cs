using Spg.FluentApi.Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FluentApi.Demo.Services
{
    public record BurgerResult(decimal Price, decimal Weight, decimal Calories, IAdditions additions) 
        : IBurgerResult
    {
        public IAdditions Additions => additions;
    }

    //public class BurgerResult : IBurgerResult
    //{
    //    public decimal Price { get; }
    //    public decimal Weight { get; }
    //    public decimal Calories { get; }

    //    public BurgerResult(decimal price, decimal weight, decimal calories)
    //    {
    //        Price = price;
    //        Weight = weight;
    //        Calories = calories;
    //    }
    //}
}
