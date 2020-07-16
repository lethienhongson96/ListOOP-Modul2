using System;
using System.Linq;
using System.Text;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isNumber("123.3"));
        }

        public static bool isNumber(string val)
        {
            int strIsNum;
            if (int.TryParse(val, out strIsNum))
            {
                return true;
            }
            return false;
        }

    }
}
