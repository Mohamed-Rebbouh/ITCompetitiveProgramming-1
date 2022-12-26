class ch9
{
    public static int tab1(int[] tab, int[] t1, int[] t2, int s1, int s2)
    {


        int i, j, cpt = 0;
        for (i = 0; i < s1; i++)
        {

            for (j = 0; j < s2; j++)
            {
                if (t1[i] == t2[j])
                {
                    tab[cpt] = t1[i];
                    cpt++;

                }




            }




        }
        return cpt;
    }
    static void Main()
    {
        int s, i;
        int[] a = { 1, 2, 3, 4 };
        int[] b = { 1, 2, 5, 67 };
        int[] c = new int[50];

        s = tab1(c, a, b, 4, 4);
        for (i = 0; i < s; i++)
        {
            Console.Write(Convert.ToString(c[i]));
            Console.Write("-");

        }


    }




}
