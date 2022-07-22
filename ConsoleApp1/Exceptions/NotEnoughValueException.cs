using System;

namespace ConsoleApp1.Exceptions
{
    class NotEnoughValueException: Exception
    {
        public NotEnoughValueException(string msg) : base(msg) { }
    }
}
