using System;

namespace hof_app{
    internal static class Functions
    {        
        /// <summary>
        /// Adds two integers
        /// </summary>
        /// <param name="a1">int one</param>
        /// <param name="b1">int two</param>
        /// <returns>sum for a1 and b1</returns>
        internal static int AddTwoIntegers(int a1, int b1)
        {
            Func<int, Func<int, int>> curriedAdd2 = a => b => a + b;
            int curriedAdd2Result = curriedAdd2(a1)(b1);

            return curriedAdd2Result;
        }

        #region Curry functions go here
        internal static void CurryFunc<T1, T2, T3, TN, TResult>()
        {
            // (T1, T2, T3, ... TN) -> TResult
            Func<T1, T2, T3, /* T4, ... */ TN, TResult> function =
                (value1, value2, value3, /* ... */ valueN) => default;
            // T1 -> T2 -> T3 -> ... TN -> TResult
            Func<T1, Func<T2, Func<T3, /* Func<T4, ... */ Func<TN, TResult> /* ... */>>> curriedFunction =
                value1 => value2 => value3 => /* value4 => ... */ valueN => default;
        }

        internal static void CallCurry(){
            Func<int, int, int> addTwo = (a, b) => a + b;
            int addTwoRes = addTwo(10, 12);

            Func<int, Func<int, int>> curriedAddTwo = addTwo.Curry();
            int curriedAddTwoRes = curriedAddTwo(4)(9);
        }
        #endregion  
    }
}