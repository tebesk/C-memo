using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XY2RT

{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> a = new Dictionary<int, List<int>>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (!a.ContainsKey(i))
                        a.Add(i, new List<int>());

                    a[i].Add(j);
                }
                int max = a[i].Max();
                Console.WriteLine("{0},{1}", (int)a[i].Max(), (int)a[i].Min());
                
            }

        }
    }
}
