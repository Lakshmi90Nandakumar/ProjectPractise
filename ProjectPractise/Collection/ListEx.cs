using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractise.Collection
{
    public class ListEx
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            list.Add("Hi");
            SortedDictionary<int,string> sd=new SortedDictionary<int,string>();
            sd.Add(101, "lakshmi");
            sd.Add(102, "rajeev");
            foreach(int s in sd.Keys)
            {
                if(s==101)
                    Console.WriteLine(sd.Values);
            }
        }
    }
}
