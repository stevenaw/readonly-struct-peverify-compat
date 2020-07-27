﻿using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal readonly struct ImmutableStack<T> : IEnumerable<T>
    {
        /// <summary>
        /// Represents an empty stack. <see langword="default"/> may be used instead.
        /// </summary>
        public static ImmutableStack<T> Empty => default(ImmutableStack<T>);

        private readonly Node _head;

        private ImmutableStack(Node head)
        {
            _head = head;
        }

        /// <summary>
        /// Returns a new immutable stack which begins with the specified value and continues with the values in the
        /// current stack.
        /// </summary>
        /// <param name="value">The beginning value of the new stack.</param>
        public ImmutableStack<T> Push(T value)
        {
            return new ImmutableStack<T>(new Node(value, _head));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var current = _head; current != null; current = current.Next)
                yield return current.Value;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private sealed class Node
        {
            public Node(T value, Node next)
            {
                Value = value;
                Next = next;
            }

            public T Value { get; }
            public Node Next { get; }
        }
    }
}
