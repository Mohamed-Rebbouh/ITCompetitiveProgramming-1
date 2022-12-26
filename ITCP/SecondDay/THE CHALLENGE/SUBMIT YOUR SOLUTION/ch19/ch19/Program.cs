using System;
class ch19
{
    static bool perfect_num(int n)
    {
        int i, s=0;
        for(i=1; i<n; i++)
        {
            if (n % i == 0)
                s = s+i;

        }

        if(s==n)
            return true;
        else
        return false;


    }


    static void Main(string[] args)
    {
        Console.WriteLine(Convert.ToString(perfect_num(28)));



    }




}
