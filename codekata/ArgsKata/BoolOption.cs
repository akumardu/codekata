using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    public class BoolOption : IOption<bool>
    {
        public BoolOption(string key)
        {
            this.key = key;
        }

        public string key
        {
            get; private set;
        }

        public bool GetValue(string parameter)
        {
            bool result = false;
            bool.TryParse(parameter, out result);
            return result;
        }
    }
}