using System;
class ch26
{
    static void Main(string[] args)
    {
        int max,j;
        string[] str = new string[50];
        Console.WriteLine("donner nomber de string =");
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i=0; i<n; i++)
        {
            Console.Write("donner string:");
            str[i]= Console.ReadLine();



        }
        max = str[0].Length;
        for(j=1;j<n;j++)
            if (str[j].Length>max)
                 max= str[j].Length;

        for(j= 0;j<max+1;j++)
        Console.Write("*");
        Console.WriteLine("*");
        for(int i = 0; i < n; i++)
        {
            Console.Write("*");
            Console.Write(str[i]);
            for (j = str[i].Length;j<max;j++)
                Console.Write(" ");
            Console.WriteLine("*");

        }

        for (j = 0; j < max +1; j++)
            Console.Write("*");
        Console.WriteLine("*");



    }



}
