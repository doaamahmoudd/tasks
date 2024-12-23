using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolvingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 10,20,23,45,96,10,21,22,21};

            List<int> _list = new List<int>();
            foreach(int num in list)
            {
                if(!_list.Contains(num))
                {
                    _list.Add(num);
                }
            }

            List<int> reversedList = new List<int>();
            for(int i=_list.Count-1;i>=0; i--)
            {
                reversedList.Add(_list[i]);
                
            }

            Console.WriteLine(string.Join(" ,",list));
            Console.WriteLine("After removing duplicates...");
            Console.WriteLine(string.Join(" ,",_list));
            Console.WriteLine("After reversing....");
            Console.WriteLine(string.Join(" ,", reversedList));

            Console.ReadKey();
        }
    }
}
