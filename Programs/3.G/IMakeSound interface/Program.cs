using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMakeSound_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IMakeSound> list = new List<IMakeSound>();

            for (int i = 0; i < 100; i++)
            {
                if (i%2 == 0) list.Add(new Dog());
                else list.Add(new Cat());
            }

            foreach (var item in list)
            {
                item.MakeSound();
            }
        }
    }
}
