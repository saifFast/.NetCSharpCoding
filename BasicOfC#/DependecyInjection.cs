using System;

namespace BasicOfC_
{
    internal class DependecyInjection
    {        
        public void Start()
        {
            var hotelManager1 = new HotelManager(new SuiteRoom());
            var hotelManager2 = new HotelManager(new SingleRoom());
        }
    }

    public interface IRoom
    {
        void CheckAvailable();
    }

    public class SuiteRoom : IRoom
    {
        public void CheckAvailable()
        {
            Console.WriteLine("Not Available");
        }
    }

    public class SingleRoom : IRoom
    {
        public void CheckAvailable()
        {
            Console.WriteLine("Available");
        }
    }

    public class HotelManager
    {
        IRoom room;
        public HotelManager(IRoom room)
        {
            this.room = room;
            this.room.CheckAvailable();
        }
    }




}
