using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    public class StringOption : IOption<string>
    {

        public StringOption(string key)
        {
            this.key = key;
        }

        public string key
        {
            get; private set;
        }

        public string GetValue(string parameter)
        {
            throw new NotImplementedException();
        }
    }
}
