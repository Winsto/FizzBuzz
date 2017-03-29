namespace RxConsoleEitherOr
{
    using System;
    using System.Runtime.CompilerServices;

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
        public abstract T Match<T>
        (
            Func<TLeft, T> matchLeftType
            , Func<TRight, T> matchRightType);

        public static Either<TLeft, TRight> Create(TLeft left)
            => new Left(left);

        public static  Either<TLeft, TRight> Create(TRight right)
            => new Right(right);

        private sealed class Left : Either<TLeft, TRight>
        {
            private readonly TLeft item;

            public Left(TLeft item)
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

            public override string ToString()
            {
                return item.ToString();
            }
        }

        private sealed class Right : Either<TLeft, TRight>
        {
            private readonly TRight item;

            public Right(TRight item)
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

            public override string ToString()
            {
                return item.ToString();
            }
        }
    }
}