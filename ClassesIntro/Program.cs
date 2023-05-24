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

            myCar.Accelerate(5);
            myCar.Accelerate(30);
            myCar.Brake(4);

            anotherCar.Brake(15);
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

        public void Accelerate(int amount)
        {
            speed += amount;
            ShowSpeed();
        }

        public void Brake(int speedReduction)
        {
            if (speed < speedReduction)
            {
                speed = 0;
            }
            else
            {
                speed -= speedReduction;
            }
            ShowSpeed();
        }

        //public void Brake(int speedReduction)
        //{
        //    speed -= speedReduction;
        //    if (speed < 0)
        //    {
        //        speed = 0;
        //    }
        //    ShowSpeed();
        //}
        private void ShowSpeed()
        {
            Console.WriteLine($"{name} is going {speed} kilometers per hour.");
        }
    }
}