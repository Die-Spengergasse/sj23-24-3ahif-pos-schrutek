using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FluentApi.Demo.Interfaces
{
    public interface IAdditions
    {
        IAdditions AddPommes();

        IAdditions AddDrink();

        IBurgerResult BuildLunch();
    }
}
