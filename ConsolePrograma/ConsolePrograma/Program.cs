using System;

namespace ConsolePrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Numeris(3,2,1));
            Console.WriteLine(InRange(4, 2, 9));
            Console.WriteLine(InRange(1, 6, 7));
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
        static bool InRange(int number, int minNum, int maxNum)
        {
            return number >= minNum && number <= maxNum;
        }
    }
}
