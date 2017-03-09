using System;
using NewStuff.Events;

namespace NewStuff
{
    public class Projection
    {
        public void Project(object @event)
        {
            switch (@event)
            {
                case CustomerAdded added:
                    Console.WriteLine($"Added {added.Name}");
                    break;
                case CustomerChangedName changedName:
                    Console.WriteLine($"Changed name to {changedName.Name}");
                    break;
                case CustomerMoved moved:
                    Console.WriteLine($"Moved to {moved.City}");
                    break;
                default:
                    throw new InvalidOperationException("Unknown event type");
            }
        }
    }
}