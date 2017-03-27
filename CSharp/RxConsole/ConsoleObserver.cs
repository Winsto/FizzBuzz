namespace RxConsole
{
    using System;
    public class ConsoleObserver<TObservable> : IObserver<TObservable>
    {
        public void OnNext(TObservable value)
            => Console.WriteLine($"Next value: {value}");

        public void OnError(Exception error)
            => Console.WriteLine($"Error: {error}");

        public void OnCompleted()
            => Console.WriteLine("Observable completed.");
    }
}