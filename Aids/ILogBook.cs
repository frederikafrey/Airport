﻿using System;

namespace Airport.Aids {
    public interface ILogBook {
        void WriteEntry(string message);
        void WriteEntry(Exception e);
    }
}