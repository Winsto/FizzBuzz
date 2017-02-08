namespace FizzBuzzTypes
{
    using System;

    /// <summary>
    /// A way of representing a Union of two types, inspired by Juliet's 
    /// answer to this 
    /// <see href="http://stackoverflow.com/questions/3151702/discriminated-union-in-c-sharp">Stack Overflow</see>
    /// question.
    /// </summary>
    /// <typeparam name="TOne"></typeparam>
    /// <typeparam name="TTwo"></typeparam>
    public abstract class UnionOfTwo<TOne, TTwo>
    {
        private readonly UnionOfTwo<TOne, TTwo> inner;

        public virtual T Match<T>
        (
            Func<TOne, T> typeOneCallback
            , Func<TTwo, T> typeTwoCallback)
        {
            return inner.Match<T>(typeOneCallback, typeTwoCallback);
        }

        public UnionOfTwo(TOne item)
        { 
            inner = new TypeOne(item);
        }

        public UnionOfTwo(TTwo item)
        {
            inner = new TypeTwo(item);
        }

        private UnionOfTwo()
        {
        }

        public sealed class TypeOne : UnionOfTwo<TOne, TTwo>
        {
            private readonly TOne item;

            public TypeOne(TOne item)
            {
                this.item = item;
            }

            public override T Match<T>(Func<TOne, T> typeOneCallback, Func<TTwo, T> typeTwoCallback)
            {
                return typeOneCallback(item);
            }
        }

        public sealed class TypeTwo : UnionOfTwo<TOne, TTwo>
        {
            private readonly TTwo item;

            public TypeTwo(TTwo item)
            {
                this.item = item;
            }


            public override T Match<T>(Func<TOne, T> typeOneCallback, Func<TTwo, T> typeTwoCallback)
            {
                return typeTwoCallback(item);
            }
        }
    }
}