using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TenMinuteWalk.Tests
{
    [TestFixture()]
    public class KataTests
    {
        private static Random rnd = new Random();

        private static string[][] pass = new string[][]
        {
      new string[] {"n","s","n","s","n","s","n","s","n","s"},
      new string[] {"e","w","e","w","n","s","n","s","e","w"},
      new string[] {"n","s","e","w","n","s","e","w","n","s"}
        };

        private static string[][] fail = new string[][]
        {
      new string[] {"n"},
      new string[] {"n","s"},
      new string[] {"n","s","n","s","n","s","n","s","n","s","n","s"},
      new string[] {"n","s","e","w","n","s","e","w","n","s","e","w","n","s","e","w"},
      new string[] {"n","s","n","s","n","s","n","s","n","n"},
      new string[] {"e","e","e","w","n","s","n","s","e","w"},
      new string[] {"n","n","n","n","n","e","e","e","e","e"},
      new string[] {"s","s","s","s","s","w","w","w","w","w"},
      new string[] {"n","n","n","n","n","w","w","w","w","w"},
      new string[] {"s","s","s","s","s","e","e","e","e","e"},
        };

        private static object[] testCases = new object[]
        {
      new object[] {fail[0], false, "should return false if walk is too short"},
      new object[] {fail[1], false, "should return false if walk is too short"},
      new object[] {fail[2], false, "should return false if walk is too long"},
      new object[] {fail[3], false, "should return false if walk is too long"},
      new object[] {fail[4], false, "should return false if walk does not bring you back to start"},
      new object[] {fail[5], false, "should return false if walk does not bring you back to start"},
      new object[] {fail[6], false, "should return false if walk does not bring you back to start"},
      new object[] {fail[7], false, "should return false if walk does not bring you back to start"},
      new object[] {fail[8], false, "should return false if walk does not bring you back to start"},
      new object[] {fail[9], false, "should return false if walk does not bring you back to start"},
      new object[] {pass[0], true, "should return true for a valid walk"},
      new object[] {pass[1], true, "should return true for a valid walk"},
      new object[] {pass[2], true, "should return true for a valid walk"},
        }.OrderBy(_ => rnd.Next()).ToArray();

        private static IEnumerable<TestCaseData> testCasesSource
        {
            get
            {
                foreach (object[] testCase in testCases)
                {
                    yield return new TestCaseData(testCase[0]).Returns(testCase[1]).SetDescription(testCase[2] as string);
                }
            }
        }

        [Test, TestCaseSource("testCasesSource")]
        public bool Walk_Validator(string[] test) => Kata.IsValidWalk(test);
    }
}
