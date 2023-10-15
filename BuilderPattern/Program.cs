using System;
using BuilderPattern.Classes;
using BuilderPattern.Interfaces;

namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {               
            while (true)
            {
                IBuilder builder;
                Director director = new Director();

                Console.Write("Choose a pen:\n1.Ballpoint pen\n2.Erasable pen\n3.Rollerball pen\n0.Exit\n");                             
                switch (Console.ReadLine())
                {
                    case "1":
                        builder = new BallpointPen();
                        director.builder = builder;

                        Console.WriteLine("Ballpoint pen");
                        director.Construct();
                        Console.WriteLine(builder.GetPen().ListParts());
                        break;
                    case "2":
                        builder = new ErasablePen();
                        director.builder = builder;

                        Console.WriteLine("Erasable pen");
                        director.Construct();
                        Console.WriteLine(builder.GetPen().ListParts());
                        break;
                    case "3":
                        builder = new RollerballPen();
                        director.builder = builder;

                        Console.WriteLine("Rollerball pen");
                        director.Construct();
                        Console.WriteLine(builder.GetPen().ListParts());
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
