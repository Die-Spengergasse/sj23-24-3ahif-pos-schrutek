using Spg.FluentApi.Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FluentApi.Demo.Services
{
    public class AdditionsConfigurator : IAdditions
    {
        private decimal _price = 0;
        private decimal _weight = 0;
        private decimal _calories = 0;

        public AdditionsConfigurator(decimal price, decimal weight, decimal calories)
        {
            _price = price;
            _weight = weight;
            _calories = calories;
        }

        public IAdditions AddDrink()
        {
            _price = _price + 3.2M;
            _weight = _weight + 0.5M;
            _calories = _calories + 130M;

            return this;
        }

        public IAdditions AddPommes()
        {
            _price = _price + 1.4M;
            _weight = _weight + 0.6M;
            _calories = _calories + 100M;

            return this;
        }

        public IBurgerResult BuildLunch()
        {
            return new BurgerResult(_price, _weight, _calories, this);
        }
    }
}
