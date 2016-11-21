﻿namespace FizzBuzzTypes
{
    public class EmptyFizz : Fizz, FizzBuzzOrNumber
    {
        public FizzBuzzOrNumber Append(NonEmptyBuzz buzz)
        {
            return buzz;
        }

        public FizzBuzzOrNumber Append(Number number)
        {
            return number;
        }

        public FizzBuzzOrNumber Append(EmptyBuzz buzz)
        {
            return this;
        }
    }
}