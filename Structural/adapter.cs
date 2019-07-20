using System;
using System.Collections;

namespace AdapterDesignPattern
{
    interface ILaptop
    {
        void ShowModel();
    }
    class HP_Laptop : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("I am an HP laptop");
        }
    }
    class Sony_Laptop
    {
        public void ShowModel()
        {
            Console.WriteLine("I am a Sony laptop");
        }
    }
    class Compaq_Laptop : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("I am a Compaq laptop");
        }
    }
    class LaptopAdaptor : ILaptop
    {
        public void ShowModel(){}
        public static void ShowModel(ILaptop obj)
        {
            obj.ShowModel();
        }
    }
    class Person
    {
        public void SwitchOn(ILaptop obj)
        {
            LaptopAdaptor.ShowModel(obj);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person();
            p.SwitchOn(new HP_Laptop()); // I am an HP laptop
            p.SwitchOn(new Compaq_Laptop()); // I am a Compaq laptop
            Console.ReadLine();
        }
    }
}