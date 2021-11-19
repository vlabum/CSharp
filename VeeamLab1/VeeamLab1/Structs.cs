using System;
using System.Collections.Generic;
using System.Text;

namespace VeeamLab1
{

    struct Base : IGetInfo
    {
        public string GetInfo()
        {
            return "Base class";
        }
    }
    struct A : IGetInfo
    {
        public string GetInfo()
        {
            return "A class";
        }
    }
}
