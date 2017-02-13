using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    public class StringOption : IOption
    {
        public T GetValue<T>()
        {
            throw new NotImplementedException();
        }

        public void SetKey(string key)
        {
            throw new NotImplementedException();
        }

        public bool SetValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
