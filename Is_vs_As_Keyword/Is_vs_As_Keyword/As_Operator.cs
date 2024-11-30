using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_vs_As_Keyword
{
    internal class As_Operator
    {

        static void Main(string[] args)
        {
            object a = 125;
            string str = a as string;
            Console.WriteLine(str);
        }

    }
}
