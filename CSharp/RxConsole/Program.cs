namespace RxConsole
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;
    using System.Reactive.Observable.Aliases;

    class Program
    {
        static void Main(string[] args)
        {
            var halfSecondTicker
                =
                Observable
                    .Interval
                    (
                        TimeSpan
                            .FromSeconds(0.5)
                    );

            IObservable<Either<Unit, Either<FizzBuzz, Either<Fizz, Buzz>>>> fizzesBuzzes
                =
                Fizzes()
                    .Zip
                    (
                        Buzzes(),
                        (fizzes, buzzes) =>
                            fizzes.Match
                            (
                                fizz =>
                                    buzzes.Match(
                                        buzz => 
                                        Either<Unit, Either<FizzBuzz, Either<Fizz, Buzz>>>
                                        .Create(
                                                Either<FizzBuzz, Either<Fizz, Buzz>>
                                                .Create(new FizzBuzz()))
                                        , 
                                        unit => 
                                        Either<Unit, Either<FizzBuzz, Either<Fizz, Buzz>>>
                                        .Create(
                                            Either<FizzBuzz, Either<Fizz, Buzz>>
                                            .Create(
                                                    Either<Fizz, Buzz>
                                                    .Create(new Fizz())))
                                    )
                                ,
                                noFizz =>
                                    buzzes.Match
                                    (
                                        buzz => 
                                        Either<Unit, Either<FizzBuzz, Either<Fizz, Buzz>>>
                                        .Create(
                                                Either<FizzBuzz, Either<Fizz, Buzz>>
                                                .Create(
                                                        Either<Fizz, Buzz>
                                                        .Create(new Buzz())))
                                        , 
                                        noBuzz =>
                                            Either<Unit, Either<FizzBuzz, Either<Fizz, Buzz>>>
                                                .Create(new Unit())
                                    )
                            )
                    );

            IObservable<Either<long, Either<FizzBuzz, Either<Fizz, Buzz>>>> finalStream
                =
                    halfSecondTicker
                    .Skip(1)
                    .Take(100)
                    .Zip
                    (
                        fizzesBuzzes,
                        (number, fb) =>
                            fb.Match(
                                unit => 
                                Either<long, Either<FizzBuzz, Either<Fizz, Buzz>>>
                                .Create(number)
                                ,
                                someValue =>
                                    Either<long, Either<FizzBuzz, Either<Fizz, Buzz>>>
                                        .Create(someValue)
                                )
                    );

            var subscription
                =
                finalStream
                    .Subscribe
                    (
                        new ConsoleObserver<Either<long, Either<FizzBuzz, Either<Fizz, Buzz>>>>()
                    );

            subscription
                .Dispose();
        }

        static IObservable<Either<Fizz, Unit>> Fizzes()
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
                                ? Either<Fizz, Unit>.Create(new Fizz())
                                :  Either<Fizz, Unit>.Create(new Unit())
                    );
        }

        static IObservable<Either<Buzz, Unit>> Buzzes()
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
                                ? Either<Buzz, Unit>.Create(new Buzz())
                                : Either<Buzz, Unit>.Create(new Unit())
                    );
        }
    }
}
