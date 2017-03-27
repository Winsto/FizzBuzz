namespace FizzBuzzTypes
{
    using System;

    /// <summary>
    /// A way of representing a Union of two types, inspired by Juliet's 
    /// answer to this 
    /// <see href="http://stackoverflow.com/questions/3151702/discriminated-union-in-c-sharp">Stack Overflow</see>
    /// question.
    /// </summary>
    /// <typeparam name="TLeft"></typeparam>
    /// <typeparam name="TRight"></typeparam>
    public abstract class Either<TLeft, TRight>
    {
        private readonly Either<TLeft, TRight> inner;

        public virtual T Match<T>
        (
            Func<TLeft, T> matchLeftType
            , Func<TRight, T> matchRightType)
        {
            return inner.Match<T>(matchLeftType, matchRightType);
        }

        protected Either(TLeft item)
        { 
            inner = new TypeOne(item);
        }

        protected Either(TRight item)
        {
            inner = new TypeTwo(item);
        }

        private Either()
        {
        }

        private sealed class TypeOne : Either<TLeft, TRight>
        {
            private readonly TLeft item;

            public TypeOne(TLeft item)
            {
                this.item = item;
            }

            public override T Match<T>
            (
                Func<TLeft, T> matchLeftType
                , Func<TRight, T> matchRightType
            )
            {
                return matchLeftType(item);
            }
        }

        private sealed class TypeTwo : Either<TLeft, TRight>
        {
            private readonly TRight item;

            public TypeTwo(TRight item)
            {
                this.item = item;
            }


            public override T Match<T>
            (
                Func<TLeft, T> matchLeftType
                , Func<TRight, T> matchRightType
            )
            {
                return matchRightType(item);
            }
        }
    }
}