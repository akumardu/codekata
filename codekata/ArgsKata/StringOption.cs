using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    using System.ComponentModel;

    public class StringOption : IOption
    {
        private string value;

        public StringOption(string defaultValue = "")
        {
            this.value = defaultValue;
        }

        public void SetKey(string arg)
        {
            this.value = arg;
        }

        public static string GetValue(IOption option)
        {
            if (option is StringOption)
            {
                return (option as StringOption).value;
            }

            throw new ArgumentException("Invalid argument");
        }
    }
}
