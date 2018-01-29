using System;

namespace Ensure.NET
{ 
    public static class Ensure
    {
        public static void Condition(bool condition, Exception exception)
        {
            if (condition == false)
                throw exception;
        }

        public static void Condition(bool condition, Action action)
        {
            if (condition == false)
                action();
        }

        public static void Condition(Func<bool> func, Action action)
        {
            if (func() == false)
                action();
        }

        public static void Condition(Func<bool> func, Exception exception)
        {
            if (func() == false)
                throw exception;
        }

        public static void Condition<T>(bool condition, ref T obj, T defaultValue)
        {
            if (condition == false)
                obj = defaultValue;
        }

        public static void Condition<T>(Func<bool> func, ref T obj, T defaultValue)
        {
            if (func() == false)
                obj = defaultValue;
        }
    }
}