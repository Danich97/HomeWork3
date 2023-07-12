using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cars.Program;

namespace cars
{
    public class BMW : car
    {
        public override void getSpeed()
        {
            Console.WriteLine("Your speed is 120 km/h" + "\n");
        }
        public override void breakSystem()
        {
            Console.WriteLine("Braking... 60 km/h" + "\n");
        }
        public override void Accelerator()
        {
            Console.WriteLine("Your acceleration is 3.5!" + "\n");
        }

        public override void CruiseControl()
        {
            Console.WriteLine("Please select the speed for cruise control");
            int cruiseControleSpeed = int.Parse(Console.ReadLine());
            int currentSpeed = 0;
            int maxSpeed = 120;

            try
            {
                if (cruiseControleSpeed <= maxSpeed)
                {
                    currentSpeed = cruiseControleSpeed;
                    Console.WriteLine("Your current speed is " + currentSpeed);
                }
                else
                {
                    throw new Exception("You can't select Cruise Control speed value more than Max Speed!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                    position++;
                }
                if (action == 2)
                {
                    position--;
                }
                if (action == 3)
                {
                    break;
                }
            }
        }

        public override void HeatOn()
        {
            Console.WriteLine("Heat on BMW!" + "\n");
        }

        public override void HeatOff()
        {
            Console.WriteLine("Heat off BMW" + "\n");
        }

        public override void TurnOnRadio()
        {
            Console.WriteLine("The radio turn on BMW" + "\n");
        }

        public override void TurnOffRadio()
        {
            Console.WriteLine("The radio turn off BMW" + "\n");
        }

        public override void ChangeStation()
        {
            Console.WriteLine("The station is changed! BMW" + "\n");
        }

        public override void IncreaseVolume()
        {
            Console.WriteLine("The volume is increased BMW" + "\n");
        }
    }
}
