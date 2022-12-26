using System;
using System.Xml.Schema;

class ch20
{
    static void Main(string[] args)
    {
        int x, y;
        x=Convert.ToInt32(Console.ReadLine());
        y= Convert.ToInt32(Console.ReadLine());

        if (x + y < 100)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");




    }

}
