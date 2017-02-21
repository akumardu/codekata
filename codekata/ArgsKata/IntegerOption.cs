using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    public class IntegerOption : IOption<int>
    {
        private string value;

        public IntegerOption(string key, string value)
        {
            this.Key = key;
        }

        public string Key
        {
            get; private set;
        }

        public int Value
        {
            get
            {
                return Int32.Parse(value);
            }
        }
    }
}
