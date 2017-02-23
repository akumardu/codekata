using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.ArgsKata
{
    // http://codingdojo.org/kata/Args/ 
    public class CommandLineArgsParser : ICommandLineArgsParser
    {
        private IDictionary<char, Type> argToTypeDict;

        private IDictionary<char, IOption> argToOptionDict = new Dictionary<char, IOption>();

        public CommandLineArgsParser(IDictionary<char, Type> optionToTypeDict)
        {
            this.argToTypeDict = optionToTypeDict;
        }

        public void Parse(string[] args)
        {
            var argsEnumerator = args.AsEnumerable().GetEnumerator();
            while (argsEnumerator.MoveNext())
            {
                string currentArg = argsEnumerator.Current;
                if (currentArg.StartsWith("-"))
                {
                    var elements = currentArg.Substring(1);
                    foreach (char element in elements)
                    {
                        if (this.argToTypeDict.ContainsKey(element))
                        {
                            this.argToOptionDict.Add(element, this.GetOptions(this.argToTypeDict[element]));
                        }
                    }
                }
            }
        }

        private IOption GetOptions(Type type)
        {
            if(type == typeof(int))
                return new IntegerOption();
            else if (type == typeof(string))
                return new StringOption();
            else if (type == typeof(bool))
                return new BoolOption();

            throw new Exception($"Invalid type {type}");
        }

        public bool GetBoolValue(char key)
        {
            if (!this.argToOptionDict.ContainsKey(key))
            {
                throw new ArgumentException($"Invalid key {key}");
            }

            var option = this.argToOptionDict[key] as BoolOption;
            return BoolOption.GetValue(option);
        }

        public int GetIntegerValue(char key)
        {
            if (!this.argToOptionDict.ContainsKey(key))
            {
                throw new ArgumentException($"Invalid key {key}");
            }

            var option = this.argToOptionDict[key] as IntegerOption;
            return IntegerOption.GetValue(option);
        }

        public string GetStringValue(char key)
        {
            if (!this.argToOptionDict.ContainsKey(key))
            {
                throw new ArgumentException($"Invalid key {key}");
            }

            var option = this.argToOptionDict[key] as StringOption;
            return StringOption.GetValue(option);
        }
    }
}
