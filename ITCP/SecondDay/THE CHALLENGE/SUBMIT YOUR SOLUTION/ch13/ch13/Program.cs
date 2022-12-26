using System;
class ch13
{
    static bool anagr(string s1,string s2)
    {
        int i, j;
        bool ana;
        for(i=0;i<s1.Length;i++)
        {
            ana = false;
            for(j=0;j<s2.Length;j++)
            {
                if (s1[i] == s2[j])
                    ana= true;
                
            }
            if (!ana)
                return false;

        }


        return true;

    }

    static void Main(string[] args)
    {

        bool a=anagr("incest", "insect");
        Console.WriteLine(Convert.ToString (a));

    }




}