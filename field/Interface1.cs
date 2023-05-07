using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace field
{
    internal interface Interface1
    {
        int X { get => X; set => ++value; }
    }
}
