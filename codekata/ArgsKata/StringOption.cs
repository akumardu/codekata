﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    public class StringOption : IOption<string>
    {
        private string value;

        public StringOption(string key, string value)
        {
            this.Key = key;
            this.value = value;
        }

        public string Key
        {
            get; private set;
        }

        public string Value
        {
            get
            {
                return value;
            }
        }
    }
}
