using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerAdmin.DomainModel.Model
{
    public class MeetingRoom : Room
    {
        protected MeetingRoom()
        { }
        public MeetingRoom(string number, int tableCount, int lockersCount, int level, string building)
            : base(number, tableCount, lockersCount, level, building)
        { }

        public bool Occupied { get; set; } = false;
    }
}
