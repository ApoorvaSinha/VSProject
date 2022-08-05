// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Icar car = new HondaFactory().CreateProduct();
            if (car != null)
            {
                Console.WriteLine("Car Type : " + car.GetCarDetails());

            }
            else
            {
                Console.Write("Invalid Car Type");
            }
            Console.WriteLine("--------------");
            car = new MarutiFactory().CreateProduct();
            if (car != null)
            {
                Console.WriteLine("Car Type : " + car.GetCarDetails());

            }
            else
            {
                Console.Write("Invalid Car Type");
            }
            Console.ReadLine();
        }
    }
}
