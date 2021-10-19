using System.Collections.Generic;

namespace shmuel_zoom_13._5._20
{
    class Flight
    {
        public string flightNumber { get; set; }
        public Queue<Passenger> passengers { get; set; }
        public Destination destination { get; set; }
        public CrewMember[] crew_Members { get; set; }
        public List<int> seats { get; set; }

        public Flight()
        {
            passengers = new Queue<Passenger>();
            crew_Members = new CrewMember[10];
            seats = new List<int>();
        }

        public override string ToString()
        {
            return "";
        }

    }

}
