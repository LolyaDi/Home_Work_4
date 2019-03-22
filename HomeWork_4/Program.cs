using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace HomeWork_4
{
    public partial class Motorcycle
    {
        public void CalculateAcceleration(ref Motorcycle motorcycle)
        {
            const int ONE_KILOMETR_IN_METERS = 1000;
            const int ONE_HOUR_IN_SECONDS = 3600;
            double SpeedInMetersPerSecond = motorcycle.MaxSpeed * ONE_KILOMETR_IN_METERS / ONE_HOUR_IN_SECONDS;

            WriteLine($"Ускорение мотоцикла {motorcycle.Brand} - {motorcycle.Model} за 10 секунд ,с максимальной скоростью {SpeedInMetersPerSecond} м/с =  {SpeedInMetersPerSecond / 10.0} м/с^2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int FIVE = 5;
            Motorcycle motorcycle = new Motorcycle();
            Motorcycle[] motorcycles = new Motorcycle[FIVE];

            motorcycle.MotorcycleInitialization();
            motorcycle.OutputCharacteristicsMotorcycle();
            motorcycle.CalculateAcceleration(ref motorcycle);


            WriteLine("Вывод конструктора по умолчанию - ");
            for(int i = 0; i < motorcycles.Length; i++)
            {
                motorcycles[i] = new Motorcycle();
                motorcycles[i].OutputCharacteristicsMotorcycle();
                motorcycles[i].CalculateAcceleration(ref motorcycles[i]);
                break;
            }

            ReadKey();
        }
    }
}
