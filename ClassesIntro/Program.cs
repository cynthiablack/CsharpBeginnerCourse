using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car("Georges");
            Car anotherCar = new Car("Marlene");

            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Brake();
            myCar.Accelerate();

            anotherCar.Brake();
        }
    }

    class Car
    {
        private int speed = 0;
        private string name;

        public Car(string carName)
        {
            name = carName;
        }

        public void Accelerate()
        {
            speed++;
            showSpeed();
        }
        public void Brake()
        {
            speed--;
            showSpeed();
        }
        private void showSpeed()
        {
            Console.WriteLine($"{name} is going {speed} kilometers per hour.");
        }
    }
}