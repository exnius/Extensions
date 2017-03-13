﻿namespace Tyrrrz.Extensions
{
    /// <summary>
    /// Extension methods for rapid development
    /// </summary>
    public static partial class Ext
    {
        /// <summary>
        /// Generic string parse delegate
        /// </summary>
        public delegate T ParseDelegate<out T>(string str);

        /// <summary>
        /// Generic string try-parse delegate
        /// </summary>
        public delegate bool TryParseDelegate<T>(string str, out T result);
    }
}