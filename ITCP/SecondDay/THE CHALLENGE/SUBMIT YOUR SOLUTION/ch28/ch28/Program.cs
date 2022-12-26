using System;
class ch28
{
    static void Main(string[] args)
    {
        int n, i,a,b;
        n=Convert.ToInt32(Console.ReadLine());
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
         
        for (i = 0; i < n; i++)
        {
            if (a % i == 0)
                Console.WriteLine("it");
            else if (b % i == 0) 
                Console.WriteLine("ccc");
        }







    }






}
