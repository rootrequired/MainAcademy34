using System;

namespace system_root_doesnt_exist_0x0081b
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boo = Convert.ToBoolean(3);
            char ch = (char)66;
            byte b = Convert.ToByte(89.5);
            sbyte sb = Convert.ToSByte(2);
            short sh = Convert.ToInt16(502);
            ushort ush = Convert.ToUInt16(16);
            int i = -29;
            uint ui = 198;
            long l = (long)122991.6;
            ulong ul = 5;
            decimal de = (decimal)-19.1;
            float f = 3.9f;
            double d0 = 32.32;
            Console.WriteLine("bool : {0}\nchar : {1}\nbyte : {2}\nsbyte : {3}\nshort : {4}\nushort : {5}\nint : {6}\nuint : {7}\n" +
            "long : {8}\nulong : {9}\ndecimal : {10}\nfloat : {11}\ndouble : {12}\n", boo, ch, b, sb, sh, ush, i, ui, l, ul, de, f, d0);


            var a = 12;
            var c = 19.5;
            Console.WriteLine("TYPE_EXIST_CHECK_A: " + a.GetType() + "\nTYPE_EXIST_CHECK_B: " + c.GetType());
            a = (int)12.5;
            c = 3;
            Console.WriteLine("TYPE_EXIST_CHECK_A: " + a.GetType() + "\nTYPE_EXIST_CHECK_C: " + c.GetType());
            System.Int32 z = i;
            System.Double y = d0;

            ch = (char)i;
            sh = b;
            l = (long)d0;
            ch = (char)f;
            ch = (char)i;
            d0 = (double)de;
            ui = b;
            sb = (sbyte)ul;
            i = (int)ch;
            d0 = l;
            f = ch;
            i = ch;
            de = (decimal)d0;
            b = (byte)ui;
            ul = (ulong)sb;
            int? p = null;
        }
    }
}
