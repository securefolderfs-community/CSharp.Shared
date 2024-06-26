﻿using System;
using System.Collections.Generic;

namespace CSharp.Shared.ComponentModel
{
    /// <summary>
    /// Represents a byte sequence of a key that can be disposed.
    /// </summary>
    public interface IKey : IEnumerable<byte>, IDisposable
    {
    }
}
