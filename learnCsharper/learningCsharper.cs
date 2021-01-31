using System;

namespace learningCsharper
{
    class Execute
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();

            HelloWorld h = new HelloWorld();
            h.Display();

            Console.ReadLine();
        }
    }

    class HelloWorld
    {
        public void Display()
        {
            Console.WriteLine("Hello World");
        }
    }

    class Rectangle
    {
        //member variables
        double lenght;
        double width;

        public void Acceptdetails ()
        {
            lenght = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return lenght * width;
        }
        public void Display()
        {
            Console.WriteLine("Lenght: {0}", lenght);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}
