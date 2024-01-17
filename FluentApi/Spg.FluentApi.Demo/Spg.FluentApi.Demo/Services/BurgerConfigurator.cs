using Spg.FluentApi.Demo.Interfaces;
using Spg.FluentApi.Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FluentApi.Demo.Services
{
    public class BurgerConfigurator : IConfigurableBurger
    {
        private decimal _price = 0;
        private decimal _weight = 0;
        private decimal _calories = 0;

        public IConfigurableBurger AddCheese()
        {
            _price = _price + 1.2M;
            _weight = _weight + 0.3M;
            _calories = _calories + 110M;

            return this;
        }

        public IConfigurableBurger AddPetty()
        {
            _price = _price + 2.0M;
            _weight = _weight + 1.0M;
            _calories = _calories + 90M;

            return this;
        }

        public IConfigurableBurger AddTomato()
        {
            _price = _price + 0.5M;
            _weight = _weight + 0.2M;
            _calories = _calories + 10M;

            return this;
        }

        public IConfigurableBurger AddSalad(Salads salad)
        {
            if (salad == Salads.Normal)
            {
                _price = _price + 0.3M;
                _weight = _weight + 0.3M;
                _calories = _calories + 12M;
            }
            else
            {
                _price = _price + 0.6M;
                _weight = _weight + 0.7M;
                _calories = _calories + 9M;
            }
            return this;
        }

        public IConfigurableBurger AddSouce(Souces souce)
        {
            switch (souce)
            {
                case Souces.Catsup:
                    _price = _price + 0.5M;
                    _weight = _weight + 0.7M;
                    _calories = _calories + 30M;
                    break;
                case Souces.Bbq:
                    _price = _price + 2.5M;
                    _weight = _weight + 0.7M;
                    _calories = _calories + 60M;
                    break;
                case Souces.Ketchup:
                    _price = _price + 1.5M;
                    _weight = _weight + 0.7M;
                    _calories = _calories + 40M;
                    break;
            }

            return this;
        }

        public IBurgerResult BuildBurger()
        {
            return new BurgerResult(
                _price, _weight, _calories, 
                new AdditionsConfigurator(_price, _weight, _weight));
        }
    }
}
