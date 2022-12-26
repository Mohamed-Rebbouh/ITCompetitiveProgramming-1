using System;

class ch25
{
    static void fabaino()
    {
        int i = 1, j = 1;int k;
        while(i + j < 100)
        {
            Console.WriteLine(Convert.ToString(i + j) + "-");
            k = i;
            i = j;
            j = j + k;


        }



    }

    static void Main()
    {

        fabaino();




    }




}
