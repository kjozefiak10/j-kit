using System;

namespace Jk.Utilities.Common
{
    public static class ArgsValidator
    {

        /// <summary>
        /// Check if <paramref name="obj"/> value is null.
        /// </summary>
        /// <exception cref="ArgumentNullException" />
        public static void IsNull(object obj, string name)
        {
            if (obj == null)
                throw new ArgumentNullException($"Argument {name} cannot be null.");
        }

        /// <summary>
        /// Check if <paramref name="str"/> value is null or empty.
        /// </summary>
        /// <exception cref="ArgumentException" />
        public static void IsNullOrEmpty(string str, string name)
        {
            IsNull(str, name);

            if (str == string.Empty)
                throw new ArgumentException($"Argument {name} cannot be empty.");
        }
    }
}
