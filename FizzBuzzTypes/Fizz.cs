﻿namespace FizzBuzzTypes
{
    public interface Fizz
    {
        FizzBuzzOrNumber Append(NonEmptyBuzz buzz);

        FizzBuzzOrNumber Append(Number number);
    }
}