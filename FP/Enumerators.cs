﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace FP {
    /// <summary>
    /// Contains extension methods on <see cref="IEnumerator{T}"/>.
    /// </summary>
    /// <remarks>
    /// All methods here assume the enumeration has started already (that is, 
    /// <see cref="IEnumerator.MoveNext"/> has been called) and consider <see cref="IEnumerator{T}.Current"/>
    /// if relevant.
    /// 
    /// The methods which return <see cref="IEnumerable{T}"/> use deferred execution, all
    /// other methods execute immediately.
    /// </remarks>
    public static class Enumerators {
        /// <summary>Advances a enumerator by a specified number of elements.</summary>
        /// <param name="enumerator">An <see cref="IEnumerator{T}" /> to advance.</param>
        /// <param name="count">The number of elements to skip.</param>
        public static void Skip<T>(this IEnumerator<T> enumerator, int count) {
            while (count > 0 && enumerator.MoveNext())
                count--;
        }

        /// <summary>Advances a enumerator as long as a specified condition is true.</summary>
        /// <returns>An <see cref="IEnumerator{T}" /> that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by <paramref name="predicate" />.</returns>
        /// <param name="enumerator">An <see cref="IEnumerator{T}" /> to advance.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        public static void SkipWhile<T>(this IEnumerator<T> enumerator, Func<T, bool> predicate) {
            while (predicate(enumerator.Current))
                enumerator.MoveNext();
        }

        /// <summary>Advances a enumerator as long as a specified condition is true.</summary>
        /// <param name="enumerator">An <see cref="IEnumerator{T}" /> to advance.</param>
        /// <param name="predicate">A function to test each element for a condition; the second parameter of the function represents the index of the source element..</param>
        public static void SkipWhile<T>(this IEnumerator<T> enumerator, Func<T, int, bool> predicate) {
            int index = 0;
            while (predicate(enumerator.Current, index)) {
                enumerator.MoveNext();
                index++;
            }
        }

        /// <summary>Advances a enumerator by a specified number of elements and returns elements read along the way.</summary>
        /// <param name="enumerator">An <see cref="IEnumerator{T}" /> to advance.</param>
        /// <param name="count">The number of elements to skip.</param>
        public static IEnumerable<T> Take<T>(this IEnumerator<T> enumerator, int count) {
            while (count > 0 && enumerator.MoveNext()) {
                count--;
                yield return enumerator.Current;
            }
        }

        /// <summary>Advances a enumerator as long as a specified condition is true and returns elements read along the way.</summary>
        /// <param name="enumerator">An <see cref="IEnumerator{T}" /> to return elements from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        public static IEnumerable<T> TakeWhile<T>(this IEnumerator<T> enumerator, Func<T, bool> predicate) {
            while (predicate(enumerator.Current)) {
                yield return enumerator.Current;
                enumerator.MoveNext();
            }
        }

        /// <summary>Advances a enumerator as long as a specified condition is true and returns elements read along the way.</summary>
        /// <param name="enumerator">An <see cref="IEnumerator{T}" /> to return elements from.</param>
        /// <param name="predicate">A function to test each element for a condition; the second parameter of the function represents the index of the source element.</param>
        public static IEnumerable<T> TakeWhile<T>(this IEnumerator<T> enumerator, Func<T, int, bool> predicate) {
            int index = 0;
            while (predicate(enumerator.Current, index)) {
                yield return enumerator.Current;
                enumerator.MoveNext();
                index++;
            }
        }
    }
}