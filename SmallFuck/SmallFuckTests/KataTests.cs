using NUnit.Framework;
using SmallFuck;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmallFuck.Tests
{
    [TestFixture()]
    public class KataTests
    {
        private static Random rng = new Random();

        [Test, Description("should work for some example test cases")]
        public void ExampleTest()
        {
            Action[] tests = new Action[]
            {
        // Flips the leftmost cell of the tape
        () => Assert.AreEqual("10101100", Smallfuck.Interpreter("*", "00101100")),
        // Flips the second and third cell of the tape
        () => Assert.AreEqual("01001100", Smallfuck.Interpreter(">*>*", "00101100")),
        // Flips all the bits in the tape
        () => Assert.AreEqual("11010011", Smallfuck.Interpreter("*>*>*>*>*>*>*>*", "00101100")),
        // Flips all the bits that are initialized to 0
        () => Assert.AreEqual("11111111", Smallfuck.Interpreter("*>*>>*>>>*>*", "00101100")),
        // Goes somewhere to the right of the tape and then flips all bits that are initialized to 1, progressing leftwards through the tape
        () => Assert.AreEqual("00000000", Smallfuck.Interpreter(">>>>>*<*<<*", "00101100")),
            };
            tests.OrderBy(x => rng.Next()).ToList().ForEach(a => a.Invoke());
        }

        // Translator's note: For easier debugging, I decided not to shuffle other tests
        [Test, Description("should ignore all non-command characters")]
        public void InvalidCharTest()
        {
            Assert.AreEqual("10101100", Smallfuck.Interpreter("iwmlis *!BOSS 333 ^v$#@", "00101100"), "Your interpreter should ignore all non-command characters");
            Assert.AreEqual("01001100", Smallfuck.Interpreter(">*>*;;;.!.,+-++--!!-!!!-", "00101100"), "Your interpreter should not treat any of \"+\", \"-\", \",\", \".\" (valid brainfuck commands) and \";\" as valid command characters");
            Assert.AreEqual("11010011", Smallfuck.Interpreter("    *  >\n    *           >\n\t\n\n*>*lskdfjsdklfj>*;;+--+--+++--+-+-  lskjfiom,x\t\n>*sdfsdf>sdfsfsdfsdfwervbnbvn*,.,.,,.,.  >\n\n\n*", "00101100"), "Your interpreter should ignore all tabs, newlines and spaces");
            Assert.AreEqual("11111111", Smallfuck.Interpreter("*,,...,..,..++-->++++-*>--+>*>+++->>..,+-,*>*", "00101100"));
            Assert.AreEqual("00000000", Smallfuck.Interpreter(">>nssewww>>wwess>*<nnn*<<ee*", "00101100"), "Your interpreter should not recognise any of \"n\", \"e\", \"s\", \"w\" (all valid Paintfuck commands) as valid commands");
        }

        [Test, Description("should return the final state of the tape immediately if the pointer ever goes out of bounds")]
        public void BoundsTest()
        {
            Assert.AreEqual("1001101000000111", Smallfuck.Interpreter("*>>>*>*>>*>>>>>>>*>*>*>*>>>**>>**", "0000000000000000"), "Your interpreter should return the final state of the tape immediately when the pointer moves too far to the right");
            Assert.AreEqual("0000000000000000", Smallfuck.Interpreter("<<<*>*>*>*>*>>>*>>>>>*>*", "0000000000000000"), "Your interpreter should immediately return the final state of the tape at the first instance where the pointer goes out of bounds to the left even if it resumes to a valid position later in the program");
            Assert.AreEqual("00011011110111111111111111111111", Smallfuck.Interpreter("*>*>*>>>*>>>>>*<<<<<<<<<<<<<<<<<<<<<*>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>*>*>*", "11111111111111111111111111111111"));
            Assert.AreEqual("1110", Smallfuck.Interpreter(">>*>*>*<<*<*<<*>*", "1101"), "Your interpreter should not follow through any command after the pointer goes out of bounds for the first time");
        }

        [Test, Description("should work for some simple and nested loops")]
        public void LoopTest()
        {
            Assert.AreEqual(new String('1', 256), Smallfuck.Interpreter("*[>*]", new String('0', 256)), "Your interpreter should evaluate a simple non-nested loop properly");
            Assert.AreEqual(new String('0', 256), Smallfuck.Interpreter("[>*]", new String('0', 256)), "Your interpreter should jump to the matching \"]\" when it encounters a \"[\" and the bit under the pointer is 0");
            Assert.AreEqual("11001100001" + new String('0', 245), Smallfuck.Interpreter("*>*>>>*>*>>>>>*>[>*]", new String('0', 256)), "Your interpreter should jump to the matching \"]\" when it encounters a \"[\" and the bit under the pointer is 0");
            Assert.AreEqual("11001100001" + new String('1', 245), Smallfuck.Interpreter("*>*>>>*>*>>>>>*[>*]", new String('0', 256)), "Your interpreter should jump back to the matching \"[\" when it encounters a \"]\" and the bit under the pointer is nonzero");
            Assert.AreEqual("1" + new String('0', 255), Smallfuck.Interpreter("*[>[*]]", new String('0', 256)), "Your interpreter should also work properly with nested loops");
            Assert.AreEqual("0" + new String('1', 255), Smallfuck.Interpreter("*[>[*]]", new String('1', 256)), "Your interpreter should also work properly with nested loops");
            Assert.AreEqual("000", Smallfuck.Interpreter("[[]*>*>*>]", "000"), "Your interpreter should also work properly with nested loops");
            Assert.AreEqual("100", Smallfuck.Interpreter("*>[[]*>]<*", "100"), "Your interpreter should also work properly with nested loops");
            Assert.AreEqual("01100", Smallfuck.Interpreter("[*>[>*>]>]", "11001"), "Your interpreter should also work properly with nested loops");
            Assert.AreEqual("10101", Smallfuck.Interpreter("[>[*>*>*>]>]", "10110"), "Your interpreter should also work properly with nested loops");
        }
    }
}