using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    public class MovieManagement
    {
        List<Ticket> _ticketList;

        public MovieManagement() { 
            _ticketList = new List<Ticket>();
        
        }
        public void createTicket(string moviename, string time, string seats) {
            string[] seat = seats.Split(',');
            foreach (string s in seat)
            {
                Ticket t = new Ticket(moviename,time,s.Trim());
                this._ticketList.Add(t);
            }
        }
        public int saleTicket() {
            return this._ticketList.Count * 120;
        }











    }
}
