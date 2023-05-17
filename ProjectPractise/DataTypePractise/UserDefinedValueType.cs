using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractise.DataTypePractise
{
    public enum WeekDays
    {
        SUNDAY,MONDAY, TUESDAY, WEDNESDAY, FRIDAY,SATURDAY
    }
    public struct SampleStruct
    {
        public SampleStruct()
        {
            Console.WriteLine("Constructor from structure");
        }
        public void display()
        {
            Console.WriteLine("Method from display method");
        }
    }
    public class UserDefinedValueType
    {
        public static void main(string[] args) 
        {
            Console.WriteLine(WeekDays.SUNDAY);
            int a =(int)WeekDays.TUESDAY;
            Console.WriteLine("Index value of tuesday in enum :  "+a);
            SampleStruct s=new SampleStruct();
            s.display();
        }
    }
}
