using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cars.Program;

namespace cars
{
    public class Lanos : car
    {
        public override void getSpeed()
        {
            Console.WriteLine("Your speed is 50 km/h" + "\n");
        }
        public override void breakSystem()
        {
            Console.WriteLine("Braking... 20 km/h" + "\n");
        }
        public override void Accelerator()
        {
            Console.WriteLine("Your acceleration is 0.5!" + "\n");
        }

        public override void CruiseControl()
        {
            Console.WriteLine("Please select the speed for cruise control");
            int cruiseControleSpeed = int.Parse(Console.ReadLine());
            int currentSpeed = 0;
            int maxSpeedBmw = 120;
            try
            {
                if (cruiseControleSpeed <= maxSpeedBmw)
                {
                    currentSpeed = cruiseControleSpeed;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You can't select Cruise Control speed value more than Max Speed!!!");
            }
        }

        public override void AdjustPostition()
        {
            int position = 0;
            while (true)
            {
                Console.WriteLine("Your current position is " + position + ". Please type 1 to increase it, 2 to lower it and 3 to exit");
                var action = int.Parse(Console.ReadLine());
                if (action == 1)
                {
                    position += 3;
                }
                if (action == 2)
                {
                    position -= 3;
                }
                if (action == 3)
                {
                    break;
                }
            }
        }

        public override void HeatOn()
        {
            Console.WriteLine("Heat on! LANOS" + "\n");
        }

        public override void HeatOff()
        {
            Console.WriteLine("Heat off LANOS" + "\n");
        }

        public override void TurnOnRadio()
        {
            Console.WriteLine("The radio turn on LANOS" + "\n");
        }

        public override void TurnOffRadio()
        {
            Console.WriteLine("The radio turn off LANOS" + "\n");
        }

        public override void ChangeStation()
        {
            Console.WriteLine("The station is changed! LANOS" + "\n");
        }

        public override void IncreaseVolume()
        {
            Console.WriteLine("The volume is increased " + "\n");
        }
    }
}
