﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    public interface ICommandLineArgsParser
    {
        void Parse(string[] args);

        bool GetBoolValue(char key);

        int GetIntegerValue(char key);

        string GetStringValue(char key);
    }
}
