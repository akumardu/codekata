using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codekata.ArgsKata;
using NUnit.Framework;

namespace codekata.tests.ArgsKataTest
{
    [TestFixture]
    public class CommandLineParserTest
    {
        [Test]
        public void TestBasicFeatures()
        {
            var dictionary = new Dictionary<char, Type>();
            dictionary.Add('d', typeof(int));
            dictionary.Add('b', typeof(bool));
            dictionary.Add('s', typeof(string));

            var args = "-b -d 100 -s hello".Split(new char[] { ' ' });

            var parser = new CommandLineArgsParser(dictionary);
            parser.Parse(args);

            Assert.AreEqual(true, parser.GetBoolValue('b'));
            Assert.AreEqual(100, parser.GetIntegerValue('d'));
            Assert.AreEqual("hello", parser.GetStringValue('s'));
        }

        [Test]
        public void TestInvalidDictionaryThrowsException()
        {
            var dictionary = new Dictionary<char, Type>();
            dictionary.Add('s', typeof(double));

            var args = "-s 90.67".Split(new char[] { ' ' });
            var parser = new CommandLineArgsParser(dictionary);

            Assert.Catch<ArgumentException>(() => { parser.Parse(args); });
        }

        [Test]
        public void TestInvalidOptionThrowsException()
        {
            var dictionary = new Dictionary<char, Type>();
            dictionary.Add('s', typeof(int));

            var args = "-d 97".Split(new char[] { ' ' });
            var parser = new CommandLineArgsParser(dictionary);
            parser.Parse(args);
            Assert.Catch<ArgumentException>(() => { parser.GetIntegerValue('d'); });
        }
    }
}
