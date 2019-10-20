﻿using System;

namespace EntityFrameworkCore.DbContextBackedMock.Moq.Extensions
{
    /// <summary>
    ///     Extensions for strings.
    /// </summary>
    [Obsolete("This package has moved to https://www.nuget.org/packages/EntityFrameworkCore.Testing.Moq/. This package will be unlisted at a later date.")]
    internal static class StringExtensions
    {
        /// <summary>
        ///     Checks to see if the target string contains the search for string using the specified string comparison..
        /// </summary>
        /// <param name="target">The string to search.</param>
        /// <param name="searchFor">The string to find within the target</param>
        /// <param name="comparer">The string comparison.</param>
        /// <returns>True if the target string contains the search for string using the specified string comparison.</returns>
        internal static bool Contains(this string target, string searchFor, StringComparison comparer)
        {
            return target.IndexOf(searchFor, 0, comparer) != -1;
        }
    }
}