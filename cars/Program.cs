using System.Diagnostics.Metrics;
using static cars.Program;

namespace cars
{
    internal class Program
    {
        interface IRadio
        {
            void TurnOnRadio();
            void TurnOffRadio();
            void ChangeStation();
            void IncreaseVolume();

        }

        interface ISeats
        {
            void AdjustPostition();

            void HeatOn();
            void HeatOff();
        }
        public abstract class car : IRadio, ISeats
        {
            public abstract void getSpeed();
            
            public abstract void breakSystem();
            
            public abstract void Accelerator();
            public abstract void AdjustPostition();
            public abstract void HeatOn();
            public abstract void HeatOff();
            public abstract void TurnOnRadio();
            public abstract void TurnOffRadio();
            public abstract void ChangeStation();
            public abstract void IncreaseVolume();
        }
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

            public override void AdjustPostition()
            {
                int position = 0;
                while (true)
                {
                    Console.WriteLine("Your current position is " + position + ". Please type 1 to increase it, 2 to lower it and 3 to exit");
                    var action = int.Parse(Console.ReadLine());
                    if (action == 1)
                    {
                        position+=2;
                    }
                    if (action == 2)
                    {
                        position-=2;
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

            public override void AdjustPostition()
            {
                int position = 0;
                while (true)
                {
                    Console.WriteLine("Your current position is " + position + ". Please type 1 to increase it, 2 to lower it and 3 to exit");
                    var action = int.Parse(Console.ReadLine());
                    if (action == 1)
                    {
                        position+=3;
                    }
                    if (action == 2)
                    {
                        position-=3;
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
                Console.WriteLine("The volume is increased LANOS" + "\n");
            }
        }
        public static void getInfo(car car)
        {
            car.getSpeed();
            car.breakSystem();
            car.Accelerator();
        }

        public static void Seat(car car)
        {
            while (true)
            {
                Console.WriteLine("Please select action with seat:" + "\n" + "1.Turn on heat" + "\n" + "2.Turn off heat" + "\n" + "3.Adjust position" + "\n" + "4.Exit");
                int actionSeat = int.Parse(Console.ReadLine());
                if (actionSeat == 1)
                {
                    car.HeatOn();
                }
                if (actionSeat == 2)
                {
                    car.HeatOff();
                }
                if (actionSeat == 3)
                {
                    car.AdjustPostition();
                }
         
                if (actionSeat == 4)
                {
                    break;
                }
            }

        }

        public static void Radio(car car)
        {
            while (true)
            {
                Console.WriteLine("Please select action with radio:" + "\n" + "1.Turn on radio" + "\n" + "2.Turn off radio" + "\n" + "3.Change the station of the radio" + "\n" + "4. Increase volume of the radio" + "\n" + "5.Exit");
                int actionRadio = int.Parse(Console.ReadLine());
                if (actionRadio == 1)
                {
                    car.TurnOnRadio();
                }
                if (actionRadio == 2) 
                { 
                    car.TurnOffRadio();
                }
                if (actionRadio == 3)
                {
                    car.ChangeStation();
                }                
                if (actionRadio == 4)
                {
                    car.IncreaseVolume();
                }
                if (actionRadio == 5)
                {
                    break;
                }
            }
        }
        public static void Main(string[] args)
        {
 
                Console.WriteLine("Please choose the car that you want to work with:");
                Console.WriteLine("1. BMW");
                Console.WriteLine("2. Volvo");
                Console.WriteLine("3. Lanos");

                int choice = int.Parse(Console.ReadLine());

                car selectedCar = null;

                if (choice == 1)
                {
                    selectedCar = new BMW();
                }
                if (choice == 2)
                {
                    selectedCar = new Volvo();
                }

                else if (choice == 3) 
                {
                    selectedCar = new Lanos();
                }
                

                if (selectedCar != null)
                {
                    while (true)
                    {
                        Console.WriteLine("Please select action:");
                        Console.WriteLine("1. Get information about the car (Speed, brake system, and accelerator)");
                        Console.WriteLine("2. Setup radio");
                        Console.WriteLine("3. Setup seat");
                        Console.WriteLine("4. Exit");

                        int action = int.Parse(Console.ReadLine());
                        
                        switch (action)
                        {
                            case 1:
                                getInfo(selectedCar);
                                break;
                            case 2:
                                Radio(selectedCar);
                                break;
                            case 3:
                                Seat(selectedCar);
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine("Invalid action. Please try again.");
                                break;
                        }
                    }
                }
            }



        }
    }
