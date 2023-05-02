using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractise.DataTypePractise
{
    public class ValueDataType
    {
        static bool rs;//declaring bollean variable
        static int a;//declaring integer variable
        static char c;//declarinig character variable
        static sbyte s;//declaring signed byte
        static short s1;//declaring short variable
        static ushort s2;//declaring unsigned short variable
        static uint b;//declaring unsigned Integer variable
        static long l;//declaring short variable
        static float f;//declaring short variable
        static double d;//declaring short variable
        public static void main()
        {
            Console.WriteLine(rs);//default value for boolean type
            rs = Convert.ToBoolean(Console.ReadLine());//converting string into boolean type
            Console.WriteLine(rs);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);//default value for int type
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c);//default value for character type
            Console.WriteLine(b);//defaul value foe unsigned integer
            b=Convert.ToUInt16(Console.ReadLine());//converting string into unsigned integer
            Console.WriteLine(b);
            Console.WriteLine(s);//default value for sbyte type

            s = -90;//storing signed data
            Console.WriteLine(s);
            s=Convert.ToSByte(Console.ReadLine());
            s1 = -87;
            Console.WriteLine(s1);
            s2 = 40;
            Console.WriteLine(s2);//unsigned short value
            Console.WriteLine(l);
            Console.WriteLine(f); //default value for float
            f = 89F;
            Console.WriteLine(f);
            Console.WriteLine(d);//default value for double
            f = Convert.ToSingle(Console.ReadLine());//converting string into float type
            Console.WriteLine(f);
            d = Convert.ToDouble(Console.ReadLine());//converting string into double type
            Console.WriteLine(d);
        }

    }
}
