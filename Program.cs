using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {  

            { 

                double Ahmad;

                Ahmad = double.Parse(Console.ReadLine());
                if (Ahmad >= 59)


                    Console.WriteLine("Passed");

                else
                    Console.WriteLine("Failed");


                double Basil;

                Basil = double.Parse(Console.ReadLine());
                if (Basil >= 99)


                    Console.WriteLine("Passed");

                else
                    Console.WriteLine("Failed");


                double Saad;

                Saad = double.Parse(Console.ReadLine());
                if (Saad >= 85)


                    Console.WriteLine("Passed");

                else
                    Console.WriteLine("Failed");



                double A;
                A = double.Parse(Console.ReadLine());
                if (A >= 59)
                    Console.WriteLine(A + 2);
                else
                    Console.WriteLine(A + 9);


                double B;
                B = double.Parse(Console.ReadLine());
                if (B >= 99)
                    Console.WriteLine(B + 2);
                else
                    Console.WriteLine(B + 9);


                double S;
                S = double.Parse(Console.ReadLine());
                if (S >= 85)
                    Console.WriteLine(S + 2);
                else
                    Console.WriteLine(S + 9);



                A = double.Parse(Console.ReadLine()); Console.WriteLine((A > 9) ? ",yes," : ".n.,");

                B = double.Parse(Console.ReadLine()); Console.WriteLine((B > 9) ? ",yes," : ".no.");

                S = double.Parse(Console.ReadLine()); Console.WriteLine((S > 9) ? ",yes," : ".no.");


                int Q;
                Q = int.Parse(Console.ReadLine());
                if (Q > 100)
                {
                    Console.WriteLine("A");
                }
                else
                if (Q > 90)
                {
                    Console.WriteLine("B");
                }
                else
                if (Q > 80)
                {
                    Console.WriteLine("S");
                }
                else
                {
                    Console.WriteLine("Failed");
                }


                int H;
                H = int.Parse(Console.ReadLine());
                if (H > 100)
                {
                    Console.WriteLine("A");
                }
                else
                if (H > 90)
                {
                    Console.WriteLine("B");
                }
                else
                if (H > 80)
                {
                    Console.WriteLine("S");
                }
                else
                {
                    Console.WriteLine("Failed");
                }


                int V;
                V = int.Parse(Console.ReadLine());
                if (V > 100)
                {
                    Console.WriteLine("A");
                }
                else
                if (V > 90)
                {
                    Console.WriteLine("B");
                }
                else
                if (V > 80)
                {
                    Console.WriteLine("S");
                }
                else
                {
                    Console.WriteLine("Failed");
                }



            }
        }

    }
}
