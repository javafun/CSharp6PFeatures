using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dictionary_Below_6()
        {
            Dictionary<string, string> builtInDataTypes = new Dictionary<string, string>()
            {
                {"Byte","0 to 255" },
                {"Boolean", "True or false."},
                {"Object", "An Object."},
                {"String", "A string of Unicode characters."},
                {"Decimal", "±1.0 × 10e-28 to ±7.9 × 10e28"}
            };

            Assert.AreEqual("True or false.", builtInDataTypes["Boolean"]);
        }

        [TestMethod]
        public void Dictionary_6()
        {
            Dictionary<string, string> builtInDataTypes = new Dictionary<string, string>()
            {
                ["Byte"] = "0 to 255",
                ["Boolean"] = "True or false.",
                ["Object"] =  "An Object.",
                ["String"] = "A string of Unicode characters.",
                ["Decimal"] = "±1.0 × 10e-28 to ±7.9 × 10e28"
            };

            Assert.AreEqual("True or false.", builtInDataTypes["Boolean"]);
        }

      


    }
}
