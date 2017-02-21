using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    public class BoolOption : IOption<bool>
    {
        private string value;

        public BoolOption(string key, string value)
        {
            this.Key = key;
            this.value = value;
        }

        public string Key
        {
            get; private set;
        }

        public bool Value
        {
            get
            {
                if (string.IsNullOrEmpty(value))
                    return true;

                return bool.Parse(value);
            }
        }
    }
}