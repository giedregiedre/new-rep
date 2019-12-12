using System;

namespace ConsolePrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Numeris(3,2,1));
        }
        static int Numeris(int n1, int n2, int n3)
        {
            if(n1 > n2 && n1 > n2)
            {
                return n1;
            }else if(n2 > n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }
    }
}
