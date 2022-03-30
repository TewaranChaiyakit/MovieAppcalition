using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    public class Ticket
    {
        string moviceName;
        string time;
        string seat;

        public Ticket(string name, string time, string seat)
        {
            this.seat = seat;
            this.time = time;
            this.moviceName = name;

            

        }
    }
}
