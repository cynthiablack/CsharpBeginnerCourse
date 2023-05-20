﻿using System;

namespace ElizaIsSilly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Doctor.Intro());
            Console.ResetColor();

            var userInput = "";
            while (!userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                userInput = Console.ReadLine();
                string response = Doctor.response(userInput);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(response);
                Console.ResetColor();
            }
        }
    }
}