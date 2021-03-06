using System;

namespace hof_app{
    public static class FunctionExtensions
    {
        // Transform (T1, T2) -> TResult
        // to T1 -> T2 -> TResult.
        public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(
            this Func<T1, T2, TResult> function) => 
                value1 => value2 => function(value1, value2);

        // Transform (T1, T2, T3) -> TResult
        // to T1 -> T2 -> T3 -> TResult.
        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> function) => 
                value1 => value2 => value3 => function(value1, value2, value3);

        // Transform (T1, T2, T3, T4) => TResult
        // to T1 -> T2 -> T3 -> T4 -> TResult.
        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> Curry<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> function) => 
                value1 => value2 => value3 => value4 => function(value1, value2, value3, value4);
    }
}