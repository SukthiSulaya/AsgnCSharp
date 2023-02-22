using System;


namespace Assignment1_5
{
    class AsgnCircle
    {
        public double circumference(double r)
        {
            double a1 = 2 * 3.142 * r;
            return a1;
        }
        public double area(double r)
        {
            double a2 = 3.142 * r * r;
            return a2;
        }
        public static void Main()
        {
            AsgnCircle c = new AsgnCircle();
            double rad, ar, cir;
            Console.WriteLine("Enter the radius : ");
            rad = Convert.ToDouble(Console.ReadLine());
            ar = c.area(rad);
            cir = c.circumference(rad);
            Console.WriteLine("area of the circle is {0}",  ar);
            Console.WriteLine("Circumference of circle is {0} ",  cir);
            Console.ReadLine();
        }
    }
}

