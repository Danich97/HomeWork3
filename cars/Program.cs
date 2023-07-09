using System.Diagnostics.Metrics;
using static cars.Program;

namespace cars
{
    public class Program
    {
        

        
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
