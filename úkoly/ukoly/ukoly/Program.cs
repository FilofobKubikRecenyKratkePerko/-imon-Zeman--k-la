internal class Program
{
    private static int i;

    static  void Main(string[] args)
    {
        //ukol c. 1 dodelany
        int[] cislick = { 1,20 , 2, 3, 4, 5, 6, 7, 8, 150, 13 };
        int max = cislick[0];
        for (int i = 1; i < cislick.Length; i++)
        {
            if (cislick[i] > max)
            {
                max = cislick[i];
            }
        }
        Console.WriteLine("FindMax: " + max);
        //nedodelane
        for (int i = 0; i < cislick.Length; i++) ;
        {
            if (cislick[i] > cislick[i + 1])
            {
                cislick[i] = cislick[i + 1];
                cislick[i+1]=cislick[i];
            }
        }
    }

}