using System;
using System.Xml;

class ch10
{
    public static bool mon(int[]tab)
    {
        int i = 0;
     
        while (tab[i] == tab[i+1] && i < tab.Length)
        {
            i++;
        }
        if (i == tab.Length - 1) return true;



        else
        {




            if (tab[i] < tab[i + 1])
            {

                while (i < tab.Length-1)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        return false;
                    }
                    else i++;

                }


            }
             else
            {

                while (i < tab.Length - 1)
                {
                    if (tab[i] <= tab[i + 1])
                        return false;
                    else i++;

                }


            }

        }

        return true;
    }


    




    static void Main()
    {
        int[] tab ={ 1, 2, 3 };
        

        Console.WriteLine(Convert.ToString(mon(tab)));



    }



}
