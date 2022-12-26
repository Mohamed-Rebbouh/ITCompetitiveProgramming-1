using System;
class ch20
{
    static bool prim(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;


        }


        return true;

    }


     static void Main(string[] args)
    {
        int n;
        Console.WriteLine("donner n=");
        n=Convert.ToInt32(Console.ReadLine());
        if (prim(n))
            Console.WriteLine("n is prim");
        else
            Console.WriteLine("n is not prin ");


    }



}