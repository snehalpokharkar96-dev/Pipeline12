using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline12
{
    internal class Program
    {
        public void sub()
        {
            int a = 50, b = 20,c;
            c = a - b;
            Console.WriteLine("sub=" + c);

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.sub();
            Console.ReadLine();
        }
    }
}
