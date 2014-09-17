using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //print car info
            //Car myCar = new Car("Honda", "Civic");

            //Car car2 = new Car();

            //Console.WriteLine(myCar.GetInfo());
            //Console.WriteLine(car2.GetInfo());

            //myCar.Honk();

            ////make a student
            //Student Pat = new Student(100001, "Pat", "McCleary");
            ////add a course
            //Pat.Courses.Add(new Course("Professional Development", "A"));
            //Pat.Courses.Add(new Course("Personal Hygein", "F"));
            //Pat.Courses.Add(new Course("Gym", "C"));
            ////print all the courses
            //Pat.PrintInfo();


            //TicketExample();

            

            //keep console open
            Console.ReadKey();
        }
        //static void TicketExample()
        //{
        //    //create a new list to hold our tickets
        //    List<Ticket> ticketList = new List<Ticket>();
        //    //create a new ticket
        //    Ticket ticket1 = new Ticket("Tyler Annis", "Had trouble with his payment", Priority.Critical);
        //    //let some time pass use,the parameter is time in miliseconds so i'm pausing for one second
        //    System.Threading.Thread.Sleep(1000);
        //    //resolve ticket one
        //    ticket1.ResolveTicket();
        //    //add it to the list
        //    ticketList.Add(ticket1);

        //    //add two more tickets to the list using HighImportance and NonCritical Priorities
        //    ticketList.Add(new Ticket("Pat", "Hockey stick is broke", Priority.NonCritical));
        //    ticketList.Add(new Ticket("Logan", "Sick today", Priority.HighImportance));

        //    //print them out too the console in order by priority
        //    Console.WriteLine(string.Join("\n", ticketList.OrderBy(x => x.Priority).Select(x => x.GetTicketInfo())));
        //    Console.WriteLine(string.Join("\n", ticketList.Where(x => x.Resolve == false).OrderBy(x => x.Priority).Select(x => x.GetTicketInfo())));
        //}
     }

    //classes can't be declared in a class
}
