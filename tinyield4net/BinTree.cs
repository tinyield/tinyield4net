using com.tinyield;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBenchmarks.SameFringe
{
    public class BinTree<T> where T : IComparable<T>
    {
        private BinTree<T> _left;
        private BinTree<T> _right;
        private T _value;

        private BinTree<T> Left
        {
            get { return _left; }
        }

        private BinTree<T> Right
        {
            get { return _right; }
        }

        // On interior nodes, any value greater than or equal to Value goes in the
        // right subtree, everything else in the left.
        private T Value
        {
            get { return _value; }
        }

        public bool IsLeaf { get { return Left == null; } }

        private BinTree(BinTree<T> left, BinTree<T> right, T value)
        {
            _left = left;
            _right = right;
            _value = value;
        }

        public BinTree(T value) : this(null, null, value) { }

        public BinTree(IEnumerable<T> values)
        {
            // ReSharper disable PossibleMultipleEnumeration
            _value = values.First();
            foreach (var value in values.Skip(1))
            {
                Insert(value);
            }
            // ReSharper restore PossibleMultipleEnumeration
        }

        public void Insert(T value)
        {
            if (IsLeaf)
            {
                if (value.CompareTo(Value) < 0)
                {
                    _left = new BinTree<T>(value);
                    _right = new BinTree<T>(Value);
                }
                else
                {
                    _left = new BinTree<T>(Value);
                    _right = new BinTree<T>(value);
                    _value = value;
                }
            }
            else
            {
                if (value.CompareTo(Value) < 0)
                {
                    Left.Insert(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }

        public IEnumerable<T> GetLeaves()
        {
            if (IsLeaf)
            {
                yield return Value;
                yield break;
            }
            foreach (var val in Left.GetLeaves())
            {
                yield return val;
            }
            foreach (var val in Right.GetLeaves())
            {
                yield return val;
            }
        }

        public void Traverse(Yield<T> yield)
        {
            if (IsLeaf)
            {
                yield(Value);
                return;
            }
            Left.Traverse(yield);
            Right.Traverse(yield);
        }

        public Advancer<T> Advancer()
        {
            Stack<BinTree<T>> stack = new Stack<BinTree<T>>();
            stack.Push(this);
            return yield =>
            {
                BinTree<T> curr = AdvanceToLeaf(stack);
                if (curr != null)
                {
                    yield(curr.Value);
                    return true;
                }
                else
                    return false;
            };
        }

        public Query<T> GetLeavesQuery()
        {

            return new Query<T>(Advancer(), this.Traverse);
        }

        private static BinTree<U> AdvanceToLeaf<U>(Stack<BinTree<U>> stack) where U : IComparable<U>
        {
            /**
			 * Loop finishes when stack is empty or it finds a Leaf.
			 */
            while (stack.Count > 0)
            {
                BinTree<U> node = stack.Pop();
                if (node.IsLeaf)
                    return node;
                BinTree<U> rightNode = node.Right;
                if (rightNode != null)
                    stack.Push(rightNode);
                BinTree<U> leftNode = node.Left;
                if (leftNode != null)
                    stack.Push(leftNode);
            }
            return null;
        }

        public bool CompareTo(BinTree<T> other)
        {
            return other.GetLeaves().Zip(GetLeaves(), (t1, t2) => t1.CompareTo(t2) == 0).All(f => f);
        }
    }
}
