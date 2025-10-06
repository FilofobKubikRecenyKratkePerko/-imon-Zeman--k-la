
namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Počet studentů: ");
            int pstudentu = Convert.ToInt32(Console.ReadLine());
            List<string> jmena = new List<string>();
            List<int> veky   = new List<int>();
            List<float>    znamky=new List<float>();
            for(int i = 0;i < pstudentu; i++)
            {
                Console.WriteLine("jmeno studenta: ");
                string jemeno = Console.ReadLine();
                Console.WriteLine("vek: ");
                int vek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pznakama: ");
                float znamka= float.Parse(Console.ReadLine());

                jmena.Add(jemeno);
                veky.Add(vek);
                znamky.Add(znamka);
            }
            bool endme = false;
            while (endme == false)
            {
                Console.WriteLine("vyber a,b,c,d: ");
                char abcd = Console.ReadKey().KeyChar;
                if (abcd == 'a')
                {
                    for(int i = 0; i < pstudentu; i++)
                    {
                        Console.WriteLine(jmena[i] +"|"+ veky[i]+" znamka " + znamky[i]);
                    }
                }
                else if (abcd == 'b')
                { 
                    for (int i = 0; i<pstudentu; i++)
                    {
                        if (znamky[i] < 2.0)
                        {
                            Console.WriteLine(jmena[i] + veky[i] + znamky[i]);
                        }
                    }
                }
                else if(abcd == 'c') 
                {
                    int plus = 0;
                    for(int i = 0;i < pstudentu; i++)
                    {
                        plus += veky[i];
                    }
                    float avrg = plus / pstudentu;
                    Console.WriteLine(avrg);
                }
                else if(abcd=='d')
                {
                    endme = true;
                }
                else
                {
                    Console.WriteLine("haha stupid");
                }

            }
        }
    }
}