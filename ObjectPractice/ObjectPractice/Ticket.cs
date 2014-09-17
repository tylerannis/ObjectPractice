using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    //declare an enumeration
    
    enum Priority
    {
        Critical,
        HighImportance,
        NonCritical
    }


    class Ticket
    {
        //declare properties
        public string ClientName {get; set;}
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public bool Resolve { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateResolved { get; set; }

        //create constructors
        public Ticket(string clientName, string descript, Priority priority)
        {
            //set our properties 
            this.ClientName = clientName;
            this.Description = descript;
            this.Priority = priority;
            this.Resolve = false;
            this.DateEntered = DateTime.Now;
            
        }
        //methods and functions
        public void ResolveTicket()
        {
            this.Resolve = true;
            this.DateResolved = DateTime.Now;
        }
        //Print ticketinfo
        public string GetTicketInfo() 
        {
            return this.ClientName + " - " + this.Description + " - " + this.Priority + " - " + DateEntered + "\nResolved: " + this.Resolve + " - " + this.DateResolved;
        }



    }
}
