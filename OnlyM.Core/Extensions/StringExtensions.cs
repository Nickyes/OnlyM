﻿namespace OnlyM.Core.Extensions
{
    using System.Linq;

    public static class StringExtensions
    {
        public static string GetNumericPrefix(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            return new string(value.TakeWhile(char.IsDigit).ToArray());
        }
    }
}
