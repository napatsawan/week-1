using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
            EnterNum a = new EnterNum();
            a.enter();
            Console.ReadKey();
        }
    }        
    class EnterNum
    {
        public void enter()
        {
            string x;
            Console.WriteLine("Enter Number:");
            x = Console.ReadLine();
            int[] enter;
            enter = x.Split(' ').Select(y => Convert.ToInt32(y)).ToArray();
            process(enter);
            output(enter);
        }
        public void process(int[] enter)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for(int i = 0; i != enter.Length -1; i++)
                {
                    if(enter[i] > enter[i + 1])
                    {
                        int temp = enter[i];
                        enter[i] = enter[i + 1];
                        enter[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
        public void output(int[] enter)
        {
            Console.WriteLine("Sort number: ");
            for(int i = 0; i != enter.Length; i++)
            {
                Console.Write(enter[i]);
                Console.Write(" ");
            }
        }
    }
}
