using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    public class BoolOption : IOption
    {
        private bool value;

        public BoolOption()
        {
            this.value = true;
        }
        
        public void SetKey(string arg)
        {
            this.value = bool.Parse(arg);
        }

        public static bool GetValue(IOption option)
        {
            if (option is BoolOption)
            {
                return (option as BoolOption).value;
            }

            throw new ArgumentException("Invalid argument");
        }
    }
}