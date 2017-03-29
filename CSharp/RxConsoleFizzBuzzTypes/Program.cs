namespace RxConsoleFizzBuzzTypes
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



            var subscription
                =
                Fizzes()
                    .Zip
                    (
                        Buzzes(),
                        (fizz, buzz) =>
                            buzz
                                .Match(
                                    emptyBuzz => fizz.Append(emptyBuzz)
                                    , nonEmptyBuzz => fizz.Append(nonEmptyBuzz))
                    )
                    .Zip
                    (
                        tickingNumbers,
                        (fb, tn) =>
                            fb.Append(tn)
                    )
                    .Take(100)
                    .Subscribe
                    (
                        new ConsoleObserver<object>()
                    );

                subscription
                .Dispose();
        }

        static IObservable<BuzzAppender> Fizzes()
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
                                ? new NonEmptyFizz() as BuzzAppender
                                : new EmptyFizz()
                    );
        }

        static IObservable<Buzz> Buzzes()
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
                                ? new Buzz(new NonEmptyBuzz())
                                : new Buzz(new EmptyBuzz())
                    );
        }
    }
}
