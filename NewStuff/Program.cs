using System;
using NewStuff.Events;

namespace NewStuff
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var projector = new Projection();

            projector.Project(new CustomerAdded {Name = "Alexey", City = "Larvik"});
            projector.Project(new CustomerChangedName {Name = "John"});
            projector.Project(new CustomerMoved {City = "Oslo"});

            Console.WriteLine("All done");
            Console.ReadLine();
        }
    }
}