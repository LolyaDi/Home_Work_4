using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace HomeWork_4
{
    public partial class Motorcycle
    {
        public string Brand { get; set; }
        
        public string Model { get; set; }

        public string Type { get; set; }

        public string PhotoAddress { get; set; }

        public int Horsepower { get; set; }

        public double Torque { get; set; }

        public int MaxSpeed { get; set; }

        public static int AverageSpeed { get; set; }

        public Motorcycle()
        {
            const int YZF_R3_MAX_SPEED = 175;
            const int YZF_R3_HORSEPOWER = 42;
            const double YZF_R3_TORQUE = 29.6;

            Brand = "Yamaha";
            Model = "YZF-R3";
            Type = "Superbike";
            MaxSpeed = YZF_R3_MAX_SPEED;
            Horsepower = YZF_R3_HORSEPOWER;
            Torque = YZF_R3_TORQUE;
            PhotoAddress = "https://www.kupimoto.com.ua/wp-content/uploads/2016/02/2016-Yamaha-YZF-R320-EU-Matt-Grey-Studio-002_gal_full.jpg";
        }

        static Motorcycle()
        {
            const int AVERAGE_SPEED_OF_MOTORCYCLE = 90;
            AverageSpeed = AVERAGE_SPEED_OF_MOTORCYCLE;
        }

        public void MotorcycleInitialization()
        {
            WriteLine("Введите марку мотоцикла - ");
            Brand = ReadLine();
            WriteLine("Введите модель мотоцикла -");
            Model = ReadLine();
            WriteLine("Введите тип(Спортивный) мотоцикла - ");
            Type = ReadLine();
            WriteLine("Введите максимальную скорость мотоцикла (км/ч) - ");
            MaxSpeed = int.Parse(ReadLine());
            WriteLine("Введите количество лошадинных сил мотоцикла - ");
            Horsepower = int.Parse(ReadLine());
            WriteLine($"Введите URL адрес фото мотоцикла {Brand} - {Model} -");
            PhotoAddress = ReadLine();
        }

        public void OutputCharacteristicsMotorcycle()
        {
            WriteLine();
            WriteLine();
            WriteLine($"Основные характеристики мотоцикла - {Brand} - {Model}");
            WriteLine($"Тип - {Type}");
            WriteLine($"Максимальная скорость - {MaxSpeed} км/ч");
            WriteLine($"Средняя скорость - {AverageSpeed} км/ч");
            WriteLine($"Мощность - {Horsepower} л.с");
            WriteLine($"URL адрес - {PhotoAddress}");
        }
    }
}