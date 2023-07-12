using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cars.Program;

namespace cars
{
    public class Volvo : car
    {
        public override void getSpeed()
        {
            Console.WriteLine("Your speed is 80 km/h" + "\n");
        }
        public override void breakSystem()
        {
            Console.WriteLine("Braking... 35 km/h" + "\n");
        }
        public override void Accelerator()
        {
            Console.WriteLine("Your acceleration is 2!" + "\n");
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
                }
                else
                {
                    throw new Exception("Your cruise control speed is above than max speed!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                currentSpeed = cruiseControleSpeed;
                Console.WriteLine("Your current speed is " + currentSpeed);
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
                    position += 2;
                }
                if (action == 2)
                {
                    position -= 2;
                }
                if (action == 3)
                {
                    break;
                }
            }
        }

        public override void HeatOn()
        {
            Console.WriteLine("Heat on! VOLVO" + "\n");
        }

        public override void HeatOff()
        {
            Console.WriteLine("Heat off VOLVO" + "\n");
        }

        public override void TurnOnRadio()
        {
            Console.WriteLine("The radio turn on VOLVO" + "\n");
        }

        public override void TurnOffRadio()
        {
            Console.WriteLine("The radio turn off VOLVO" + "\n");
        }

        public override void ChangeStation()
        {
            Console.WriteLine("The station is changed! VOLVO" + "\n");
        }

        public override void IncreaseVolume()
        {
            Console.WriteLine("The volume is increased VOLVO" + "\n");
        }
    }
}
