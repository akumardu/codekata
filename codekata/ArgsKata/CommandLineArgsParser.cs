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
            for(int i =0; i < args.Length; i++)
            {
                string currentArg = args[i];
                if (currentArg.StartsWith("-"))
                {
                    
                    var elements = currentArg.Substring(1,1);
                    foreach (char element in elements)
                    {
                        if (this.argToTypeDict.ContainsKey(element))
                        {
                            var option = this.GetOptions(this.argToTypeDict[element]);
                            if(i < args.Length-1 && !args[i + 1].StartsWith("-"))
                            {
                                option.SetValue(args[i + 1]);
                                i++;
                            }

                            this.argToOptionDict.Add(element, option);
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

            throw new ArgumentException($"Invalid type {type}");
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
