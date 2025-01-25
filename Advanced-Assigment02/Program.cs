using System.Collections;

namespace Advanced_Assigment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            Console.WriteLine("Enter size of array Then Enter Number of Queries");
            int ArraySize = int.Parse(Console.ReadLine());
            List<int> arrayList = new List<int>(ArraySize);
            int Qsize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < ArraySize; i++)
            {
                arrayList.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Enter Queries");
            List<int> resultcounter = new List<int>();
            for (int i = 0; i < Qsize; i++)
            {
                int X = int.Parse(Console.ReadLine());
                int count = 0;
                for (int j = 0; j < ArraySize; j++)
                {
                    if (arrayList[j] > X)
                    {
                        count++;
                    }
                }
                resultcounter.Add(count);
            }
            Console.WriteLine("OutPut : ");
            foreach (int i in resultcounter)
            {
                Console.WriteLine(i);
            }
            #endregion


        }
    }
}
