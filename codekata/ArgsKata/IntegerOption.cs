using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    public class IntegerOption : IOption
    {
        private int value;

        public IntegerOption(int defaultValue = 0)
        {
            this.value = defaultValue;
        }

        public static int GetValue(IOption option)
        {
            if (option is IntegerOption)
            {
                return (option as IntegerOption).value;
            }

            throw new ArgumentException("Invalid argument", nameof(option));
        }

        public void SetValue(string arg)
        {
            this.value = Int32.Parse(arg);
        }
    }
}
