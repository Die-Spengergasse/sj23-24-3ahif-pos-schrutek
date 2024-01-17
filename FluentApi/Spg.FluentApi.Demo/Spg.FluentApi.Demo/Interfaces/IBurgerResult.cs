using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FluentApi.Demo.Interfaces
{
    public interface IBurgerResult
    {
        decimal Price { get; }
        decimal Weight { get; }
        decimal Calories { get; }
        IAdditions Additions { get; }
    }
}
