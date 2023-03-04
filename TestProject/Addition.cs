using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TestProject
{
    public class Addition
    {
        public int add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}
