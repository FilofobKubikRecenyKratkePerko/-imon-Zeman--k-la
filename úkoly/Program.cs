internal class Program
{
    private static int i;

    static void Main(string[] args)
    {
        //ukol c. 1 
        int[] cislick = { 1, 20, 2, 3, 4, 5, 6, 7, 8, 150, 13 };
        int max = cislick[0];
        for (int i = 1; i < cislick.Length; i++)
        {
            if (cislick[i] > max)
            {
                max = cislick[i];
            }
        }
        Console.WriteLine("FindMax: " + max);
        //ukol c.2
        Array.Sort(cislick);
        Array.Reverse(cislick);
        foreach (int i in cislick)
        {
            Console.WriteLine(i);
        }
        //ukol c.3
        Array.Reverse(cislick);
        int target = 8;
        int index = BinarySearch(cislick, target);
        if (index != -1)
        {
            Console.WriteLine("Cislo " + target + " bylo nalezeno na pozici " + index);
        }
        else
        {
            Console.WriteLine("cislo "+target+ " nenalezeno");
        }

    }
    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
        
    }

}