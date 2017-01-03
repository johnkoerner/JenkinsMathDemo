using System;
using System.Collections;
using System.Linq;

namespace MathLibrary
{
    public static class Addition
    {
        public static int Add(params int []i)
        {
            return i?.Sum() ?? 0;
        }
    }
}
