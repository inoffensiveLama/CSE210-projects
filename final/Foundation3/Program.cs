using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Cityville", "Stateville", "12345");

        List<Event> events = new List<Event>
        {
            new LectureEvent("Interesting Lecture", "Learn something new", "2023-01-01", "18:00", address, "John Doe", 100),
            new ReceptionEvent("Grand Reception", "Celebrate together", "2023-02-15", "20:00", address, "rsvp@example.com"),
            new OutdoorGatheringEvent("Summer Picnic", "Enjoy the outdoors", "2023-06-30", "12:00", address, "sunny and warm"),
        };

        foreach (Event ev in events)
        {
            Console.WriteLine("=== Standard Details ===");
            Console.WriteLine(ev.ToString());

            Console.WriteLine("\n=== Full Details ===");
            Console.WriteLine(ev.ToStringFullDetails());

            Console.WriteLine("\n=== Short Description ===");
            Console.WriteLine(ev.ToStringShort());

            Console.WriteLine("\n----------------------------------------\n");
        }
    }
}