using System;

namespace Event_1
{

    // Step 1: Create a delegate type
    // Step 2: Use the delegate type to create an event, such that, all event handlers
    // obeys the delegate type

    public delegate void Notify();

    class Program
    {
        static void Main(string[] args)
        {
            Weather w = new Weather();
            w.HurricanIsComing += Citizen.evacuate;
            w.HurricanIsComing += TVBroadcastAgency.broadcastNews;
            w.HurricanIsComing += GovtAgency.provideFacility;
            w.checkWeather();


        }
    }

    class Citizen
    {
        public static void evacuate()
        {
            Console.WriteLine("Let's pack and leave");
        }
    }

    class TVBroadcastAgency
    {
        public static void broadcastNews()
        {
            Console.WriteLine("Breaking News!! Hurricane is coming");
        }
    }

    class GovtAgency
    {
        public static void provideFacility()
        {
            Console.WriteLine("Prepare for the hurricane");
        }
    }

    class Weather {

        public event Notify HurricanIsComing;

        public void checkWeather()
        {
            if (true)
            {
                OnHurricaneIsComing(); // raising the event
            }
        }

        public void OnHurricaneIsComing()
        {
            if (HurricanIsComing != null) // checking if there are subscribers to this event
                HurricanIsComing.Invoke(); // invoke those event handlers/subscribers
        }
    }
}
