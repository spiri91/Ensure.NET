using System;

namespace Ensure.NET
{ 
    public static class Ensure
    {
        /// <summary>
        /// If condition is not met than that exception is thrown, otherwise nothing happens
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="exception"></param>
        public static void Condition(bool condition, Exception exception)
        {
            if (condition == false)
                throw exception;
        }

        /// <summary>
        /// If condition is not met than that action will be executed
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="action"></param>
        public static void Condition(bool condition, Action action)
        {
            if (condition == false)
                action();
        }

        /// <summary>
        /// If condition is not met than the action will be executed
        /// </summary>
        /// <param name="func"></param>
        /// <param name="action"></param>
        public static void Condition(Func<bool> condition, Action action)
        {
            if (condition() == false)
                action();
        }

        /// <summary>
        /// If condition is not met than that exception is thrown, otherwise nothing happens
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="exception"></param>
        public static void Condition(Func<bool> condition, Exception exception)
        {
            if (condition() == false)
                throw exception;
        }

        /// <summary>
        /// If condition is not met obj will take the values specified in parameter named defaultValue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="condition"></param>
        /// <param name="obj"></param>
        /// <param name="defaultValue"></param>
        public static void Condition<T>(bool condition, ref T obj, T defaultValue)
        {
            if (condition == false)
                obj = defaultValue;
        }

        /// <summary>
        /// If condition is not met obj will take the values specified in parameter named defaultValue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="obj"></param>
        /// <param name="defaultValue"></param>
        public static void Condition<T>(Func<bool> func, ref T obj, T defaultValue)
        {
            if (func() == false)
                obj = defaultValue;
        }
    }
}