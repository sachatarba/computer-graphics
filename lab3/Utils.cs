using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Utils
    {
        public static int Sign(float x)
        {
            if (x < 0) return -1;
            if (x > 1) return 1;
            return 0;
        }  
    }
}
