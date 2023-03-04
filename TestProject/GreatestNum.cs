using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class GreatestNum
    {
        public int maxFind(int a,int b,int c) {
            if (a > b && a > c)
                return a;
            if (b > a && b > c)
                return b;
            else
                return c;
        }
    }
}
