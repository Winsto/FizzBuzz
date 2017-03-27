namespace RxConsole
{
    using System;
    using System.Reactive.Linq;
    using System.Reactive.Observable.Aliases;
    using FizzBuzzTypes;

    class Program
    {
        static void Main(string[] args)
        {
            var oneSecondTicker
                =
                Observable
                    .Interval
                    (
                        TimeSpan
                            .FromSeconds(1)
                    );

            var tickingNumbers
                =
                oneSecondTicker
                    .Skip(1)
                    .Map
                    (
                        t => new Number((int) t)
                    );

            IObservable<NumberAppender> fizzOrBuzzOrFizzBuzz
                =
                Fizzes()
                    .Zip
                    (
                        Buzzes(),
                        (f, b) =>
                            f.Match
                            (
                                fizz =>
                                    b.Match(
                                        buzz => fizz.Append(buzz)
                                        , emptyBuzz => fizz.Append(emptyBuzz)
                                    )
                                ,
                                emptyFizz =>
                                    b.Match
                                    (
                                        buzz => emptyFizz.Append(buzz)
                                        , emptyBuzz => emptyFizz.Append(emptyBuzz)
                                    )
                            )
                    );

            IObservable<object> finalStream
                =
                tickingNumbers
                    .Take(100)
                    .Zip
                    (
                        fizzOrBuzzOrFizzBuzz,
                        (number, numberAppender) =>
                            numberAppender.Append(number)
                    );

            var subscription
                =
                finalStream
                    .Subscribe
                    (
                        new ConsoleObserver<object>()
                    );

            subscription
                .Dispose();
        }

        static IObservable<FizzOrEmptyFizz> Fizzes()
        {
            return 
                Observable
                .Generate
                    (
                        1,
                        i => true,
                        i => i + 1,
                        i =>
                            i % 3 == 0
                                ? new FizzOrEmptyFizz(new NonEmptyFizz())
                                : new FizzOrEmptyFizz(new EmptyFizz())
                    );
        }

        static IObservable<BuzzOrEmptyBuzz> Buzzes()
        {
            return
                Observable
                    .Generate
                    (
                        1,
                        i => true,
                        i => i + 1,
                        i =>
                            i % 5 == 0
                                ? new BuzzOrEmptyBuzz(new NonEmptyBuzz())
                                :  new BuzzOrEmptyBuzz(new EmptyBuzz())
                    );
        }
    }
}
