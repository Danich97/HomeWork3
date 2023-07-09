using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
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
}
