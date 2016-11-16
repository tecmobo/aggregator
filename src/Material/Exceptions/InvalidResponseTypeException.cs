﻿using System;

namespace Material.Exceptions
{
    public class InvalidResponseTypeException : Exception
    {
        public InvalidResponseTypeException(string message) : base(message) { }

        public InvalidResponseTypeException() : base() { }

        public InvalidResponseTypeException(string message, Exception exception) : 
            base(message, exception) { }
    }
}
