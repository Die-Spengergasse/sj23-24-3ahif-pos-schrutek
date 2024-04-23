using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerAdmin.DomainModel.Model
{
    public partial class ClassRoom
    {
        public string ProtertyInSecondPart { get; set; }

        /// <summary>
        /// Bad Practice:
        /// * Faker wird auch im DomainModel verwendet, das ist nicht gut.
        /// Sollte nur in der Infrastructure verwendet werden.
        /// * Unnötige Dependecies!!!
        /// * Lesbarkeit von partial classes ist fragwürdig
        /// * Seed-Part befindetisch in ein einem "gefakten" Namespace. (fragwürdig)
        /// SUMME: Bitte nicht nachmachen
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static ClassRoom Seed(Faker f)
        {
            var buildings = new string[] { "A", "B", "C", "D", };

            string building = f.Random.ArrayElement(buildings);
            return new ClassRoom(
                $"{building}{f.Random.Int(1, 5)}.{f.Random.Int(0, 20).ToString().PadLeft(3, '0')}",
                f.Random.Int(1, 20),
                f.Random.Int(1, 20),
                f.Random.Int(1, 5),
                building);
        }
    }
}
