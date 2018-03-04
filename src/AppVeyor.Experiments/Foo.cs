// Copyright (c) Arjen Post. See LICENSE in the project root for license information.
using System.Linq;

namespace AppVeyor.Experiments
{
    /// <summary>
    /// Provides a method for testing purposes.
    /// </summary>
    public static class Foo
    {
        /// <summary>
        /// Returns the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The given <paramref name="value"/>.</returns>
        public static string Bar(string value)
        {
            return new string(value.Reverse().ToArray());
        }
    }
}
