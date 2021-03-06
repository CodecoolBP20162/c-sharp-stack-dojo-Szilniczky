﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackEmptyException : Exception
    {
        public StackEmptyException()
        {
        }

        public StackEmptyException(string message)
            : base(message)
        {
        }

        public StackEmptyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
