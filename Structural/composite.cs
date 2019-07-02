using System;
using System.Collections;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;

namespace CompositeDesignPattern
{
    // Root Node
    interface IDraw
    {
        void Draw();
    }
    // Chile Node
    class Circle : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("I am a circle");
        }
    }
    // Child Node
    class Square : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("I am a square");
        }
    }
    // Child Node
    class Oval : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("I am an oval");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objList = new ArrayList();
            IDraw objCircle = new Circle();
            IDraw objSquare = new Square();
            IDraw objOval = new Oval();
            objList.Add(objCircle);
            objList.Add(objSquare);
            objList.Add(objOval);
            foreach (IDraw obj in objList)
            {
                obj.Draw();
            }
            Console.ReadLine();
        }
    }
}