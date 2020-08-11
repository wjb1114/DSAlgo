using System;
using System.Collections.Generic;

namespace BigOOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var testOne = new OOfNExample();
            testOne.TestLinear();
            testOne.TestConstant(new List<string> { "one", "two", "three" });
        }
    }
}
