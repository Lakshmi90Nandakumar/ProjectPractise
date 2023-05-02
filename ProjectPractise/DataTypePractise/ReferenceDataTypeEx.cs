using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractise.DataTypePractise
{
    public class ReferenceDataTypeEx:IReferenceEx//class is reference data type where using reference we can access the properties
    {
        int a = 10, b = 20;
        public ReferenceDataTypeEx()
        {
            Console.WriteLine("This is Constructor");
        }
        public void add()
        {
            Console.WriteLine("Addition is:  " + (a + b));
        }
    }
    public interface IReferenceEx
    {
        public void add();
    }
    public class ImplementEx
    {
        public static void main(string[] args) 
        {


            IReferenceEx rf= new ReferenceDataTypeEx();
            rf.add();
        }
    }
}
