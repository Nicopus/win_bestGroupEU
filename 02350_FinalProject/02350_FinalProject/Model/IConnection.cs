using System;
using System.Collections.Generic;
using System.Linq;

namespace _02350_FinalProject.Model
{
    public interface IConnection
    {
        int FromNumber { get; }
        string FromMultiplicity { get; }
        int ToNumber { get; }
        string ToMultiplicity { get; }
        string Label { get; }
        EConnection Type { get; }
    }
}
