using System;

namespace hof_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Functions.AddTwoIntegers(4, 5);

            // Test calling curry functions
            Functions.CallCurry();
        }
    }
}
