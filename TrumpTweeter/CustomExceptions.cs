﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpTweeter
{
    class CustomExceptions
    {
        
    }

    public class ConnectionAbortedException : Exception
    {
        public ConnectionAbortedException(string message): base(message)
        {
        }
    }

}
