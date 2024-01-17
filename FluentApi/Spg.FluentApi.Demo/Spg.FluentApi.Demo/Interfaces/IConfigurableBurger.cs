using Spg.FluentApi.Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FluentApi.Demo.Interfaces
{
    public interface IConfigurableBurger
    {
        IConfigurableBurger AddPetty();

        IConfigurableBurger AddCheese();

        IConfigurableBurger AddTomato();

        IConfigurableBurger AddSalad(Salads salad);

        IConfigurableBurger AddSouce(Souces souce);
        
        IBurgerResult BuildBurger();
    }
}
