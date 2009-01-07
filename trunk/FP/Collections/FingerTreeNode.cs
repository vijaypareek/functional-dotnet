/*
* FingerTreeNode.cs is part of functional-dotnet project
* 
* Copyright (c) 2008-2009 Alexey Romanov
* All rights reserved.
*
* This source file is available under The New BSD License.
* See license.txt file for more information.
* 
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
* CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
* INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
* MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using FP.Util;

namespace FP.Collections {
    /// <summary>
    /// A node in the middle section of a deep finger tree.
    /// </summary>
    /// <typeparam name="T">Type of the elements in the node.</typeparam>
    /// <typeparam name="V">Type of the weight monoid.</typeparam>
    internal sealed class FTNode<T, V> : IMeasured<V>, IEnumerable<T>, IFoldable<T>,
                                         IEquatable<FTNode<T, V>>
        where T : IMeasured<V> {

        internal FTNode(V measure, params T[] array) {
            Debug.Assert(array.Length == 2 || array.Length == 3);
            Measure = measure;
            AsArray = array;
        } // FTNode

        internal FTNode(Monoid<V> measureMonoid, params T[] array) :
            this(measureMonoid.SumMeasures(array), array) { } // FTNode

        public A FoldRight<A>(Func<T, A, A> binOp, A initial) {
            return AsArray.FoldRight(binOp, initial);
        } // FoldRight

        public A FoldLeft<A>(Func<A, T, A> binOp, A initial) {
            return AsArray.FoldLeft(binOp, initial);
        } // FoldLeft

        public V Measure { get; private set; } // Measure

        /// <summary>
        /// Gets the node's representation as an array.
        /// </summary>
        /// <remarks>Do not mutate!</remarks>
        internal T[] AsArray { get; private set; } // AsArray

        /// <summary>
        /// Returns an enumerator that iterates through the node.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the node.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public IEnumerator<T> GetEnumerator() {
            for (int i = 0; i < AsArray.Length; i++)
                yield return AsArray[i];
        } // GetEnumerator

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        } // IEnumerable.GetEnumerator

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(FTNode<T, V> other) {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Measure, Measure) && Arrays.ContentEquals(other.AsArray, AsArray);
        } // Equals

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.
        /// </summary>
        /// <returns>
        /// true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.
        /// </returns>
        /// <param name="obj">
        /// The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />. 
        /// </param>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj" /> parameter is null.
        /// </exception><filterpriority>2</filterpriority>
        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            var node = obj as FTNode<T, V>;
            if (node == null) return false;
            return Equals(node);
        } // Equals

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object" />.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode() {
            unchecked {
                int result = AsArray[0].GetHashCode();
                result = (result * 397) ^ AsArray[1].GetHashCode();
                if (AsArray.Length == 3)
                    result = (result * 397) ^ AsArray[2].GetHashCode();
                return result;
            }
        } // GetHashCode

        public static bool operator ==(FTNode<T, V> left, FTNode<T, V> right) {
            return Equals(left, right);
        } // op_Equality

        public static bool operator !=(FTNode<T, V> left, FTNode<T, V> right) {
            return !Equals(left, right);
        } // op_Inequality
    } // class FTNode`2
}