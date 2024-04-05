using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class Room
    {
        protected Room()
        { }
        public Room(string number, int tableCount, int lockersCount, int level, string building)
        {
            Number = number;
            TableCount = tableCount;
            LockersCount = lockersCount;
            Level = level;
            Building = building;
        }

        // Id ... P.K. ; int/long ... Auto Increment (Convention over Configuration)
        // ID kommt IMMER aus der DB.
        public int Id { get; private set; }
        public string Number { get; set; } = string.Empty;
        public int TableCount { get; set; }
        public int LockersCount { get; set; }
        public int Level { get; set; }
        public string Building { get; set; } = string.Empty;
    }
}
