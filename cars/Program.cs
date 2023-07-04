using System.Diagnostics.Metrics;

namespace cars
{
    internal class Program
    {
        public abstract class car
        {
            public abstract void getSpeed();
            
            public abstract void breakSystem();
            
            public abstract void Accelerator();
        }
        public class BMW : car
        {
            public override void getSpeed()
            {
                Console.WriteLine("Your speed is 120 km/h");
            }
            public override void breakSystem()
            {
                Console.WriteLine("Braking... 60 km/h");
            }
            public override void Accelerator()
            {
                Console.WriteLine("Your acceleration is 3.5!");
            }
        }
        public class Volvo : car
        {
            public override void getSpeed()
            {
                Console.WriteLine("Your speed is 80 km/h");
            }
            public override void breakSystem()
            {
                Console.WriteLine("Braking... 35 km/h");
            }
            public override void Accelerator()
            {
                Console.WriteLine("Your acceleration is 2!");
            }
        }
        public class Lanos : car
        {
            public override void getSpeed()
            {
                Console.WriteLine("Your speed is 50 km/h");
            }
            public override void breakSystem()
            {
                Console.WriteLine("Braking... 20 km/h");
            }
            public override void Accelerator()
            {
                Console.WriteLine("Your acceleration is 0.5!");
            }
        }
        public static void getInfo(car car)
        {
            car.getSpeed();
            car.breakSystem();
            car.Accelerator();
        }
        public static void Main(string[] args)
        {
            getInfo(new BMW());
            getInfo(new Volvo());
            getInfo(new Lanos());
        }
    }
}