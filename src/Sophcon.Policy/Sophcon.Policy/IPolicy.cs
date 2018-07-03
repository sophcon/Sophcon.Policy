using System;
using System.Collections.Generic;
using System.Text;

namespace Sophcon.Policy
{
    public interface IPolicy<T>
    {
        PolicyResult Evaluate();
        T Subject { get; set; }
    }
}
