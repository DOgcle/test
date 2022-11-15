using System;
using System.Collections.Generic;

namespace test1
{
    class Program
    {
        
        private static int[] number = new int[] { 0, 1, 2, 3, 4, 5 };
        public int[] Max;
        public int[] Min;
        public int[] a;
        public Program()
        {
            this. Max = new int[1] { 0 };
            this.Min = new int[1] { 0 };
            this.a = new int[1] { 0 };

        }
        public void Chia()
        {
           
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (number[j] != 0)
                    {
                        a[0] = number[i] / number[j];

                        if (a[0] > Max[0])
                        {
                            Max[0] = a[0];
                        }
                        else if (a[0] < Min[0])
                        {
                            Min[0] = a[0];
                        }
                    }

                }  
            }
            Console.WriteLine("Ketqua");
            Console.WriteLine(Max[0]);
            Console.WriteLine(Min[0]);
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Chia();
            
        }
    }
}
