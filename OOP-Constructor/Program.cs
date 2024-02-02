using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.carShow();

            Console.ReadKey();
        }
    }

    class Car
    {
        // fields
        string make;
        string model;
        int year;
        string color;

        // Constructor
        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        // Object 
        public void Drive()
        {
            Console.WriteLine($"You drive the {make} {model}");
        }

        public void carShow()
        {
            Console.WriteLine($"You are driving a {color} {make} {model} for the carshow?");
        }

        
    }
  
}