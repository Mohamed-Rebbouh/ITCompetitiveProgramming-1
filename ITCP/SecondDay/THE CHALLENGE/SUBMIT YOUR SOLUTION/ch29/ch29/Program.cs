using System;
class ch29
{
    static int somme (int x, int y)
    {


        return x + y;

    }

    static void Main(string[] args)
    {

        int x, y;
        Console.WriteLine("doner number:");
        x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("doner number:");
        y= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("sommer is="+Convert.ToString(somme(x, y)));



    }




}
