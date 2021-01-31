using System;

namespace learningCsharper
{
    class Execute
    {
        static void Main(string[] args)
        {
            HelloWorld h = new HelloWorld();
            h.Display();

            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();

            Program p = new Program();
            p.Display();

            ExplicitConversion e = new ExplicitConversion();
            e.Display();

            StringConversion s = new StringConversion();
            s.Display();

            VariableDefinition v = new VariableDefinition();
            v.Display();

            EscapeChar ec = new EscapeChar();
            ec.Display();

            Declaringconstants dc = new Declaringconstants();
            dc.Display();

            DecisionMaking dm = new DecisionMaking();
            dm.Display();

            Grades g = new Grades();
            g.Display();

            Countdown cd = new Countdown();
            cd.Display();

            Countup cu = new Countup();
            cu.Display();

            Console.ReadLine();
        }
    }

    class HelloWorld
    {
        public void Display()
        {
            Console.WriteLine("Hello World\n");
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
            Console.WriteLine("Area: {0}\n", GetArea());
        }
    }

    class Program
    {
        public void Display()
        {
            Console.WriteLine("Size of int: {0}\n", sizeof(int));
        }
    }

    class ExplicitConversion
    {
        public void Display()
        {
            double d = 5673.74;
            int i;

            //cast double to int.
            i = (int)d;
            Console.WriteLine("{0}\n", i);
        }
    }

    class StringConversion
    {
        public void Display()
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine("{0}\n", b.ToString());

        }
    }

    class VariableDefinition
    {
        public void Display()
        {
            short a;
            int b;
            double c;

            //actual initialization
            a = 10;
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}\n", a, b, c);
        }
    }

    class EscapeChar
    {
        public void Display()
        {
            Console.WriteLine("Hello\tWorld\n");
        }
    }

    class Declaringconstants
    {
        public void Display()
        {
            const double pi = 3.14159;

            //constant declaration
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}\n", r, areaCircle);
        }
    }

    class DecisionMaking
    {
        public void Display()
        {
            double r;
            Console.WriteLine("Is this number less than 20? Enter a number:");
            r = Convert.ToDouble(Console.ReadLine());

            if (r < 20)
            {
                Console.WriteLine("Your chosen value of {0} is less than 20", r);
            } else if (r == 20)
            {
                Console.WriteLine("Your choses value of {0} is exactly 20", r);
            } else
            {
                Console.WriteLine("Your chosen value of {0} is more than 20\n", r);
            }
        }
    }

    class Grades
    {
        public void Display()
        {
            double grade;
            Console.WriteLine("Fill in your grade:");
            grade = Convert.ToDouble(Console.ReadLine());

            switch (grade)
            {
                case 5:
                    Console.WriteLine("Excellent!\n");
                    break;
                case 4:
                    Console.WriteLine("Good\n");
                    break;
                case 3:
                    Console.WriteLine("okay\n");
                    break;
                case 2:
                    Console.WriteLine("not bad\n");
                    break;
                case 1:
                    Console.WriteLine("acceptable\n");
                    break;
                case 0:
                    Console.WriteLine("failing grade\n");
                    break;
                default:
                    Console.WriteLine("Incorrect\n");
                    break;
            }
        }
    }

    class Countdown
    {
        public void Display()
        {
            double a;
            Console.WriteLine("Count down from: ");
            a = Convert.ToDouble(Console.ReadLine());

            while (a > -1)
            {
                Console.WriteLine("Value of a: {0}", a);
                System.Threading.Thread.Sleep(100);
                a--;

                if (a > 10)
                {
                    Console.WriteLine("This value is too high");
                    break;
                }
            }
            Console.WriteLine("GO! GO! GO!\n");
        }
    }

    class Countup
    {
        public void Display()
        {
            for (int a = 10; a < 20; a = a + 1)
            {
                Console.WriteLine("value of a: {0}", a);
            }
        }
    }
}