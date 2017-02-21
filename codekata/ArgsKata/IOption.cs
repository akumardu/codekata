using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    public interface IOption<T>
    {
        string Key { get; }

        T Value { get; }
     }
}
