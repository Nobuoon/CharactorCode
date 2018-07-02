using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using CharactorCode;

namespace CharactorCodeUnitTest
{
    [TestClass]
    public class CharactorCodeTesterUnitTest
    {
        [TestMethod]
        public void TestAscii()
        {
            var tester = new CharactorCodeTester();

            tester.TestRange(CharactorCode.CharactorCode.ASCII_RANGE, "", CheckASCIIEditing, Assert.IsFalse);



        }

        private bool CheckASCIIEditing(string key, string value)
        {
            var ascii = new ASCIIEncoding();
            var bytes = ascii.GetBytes(value.ToCharArray());
            var str = ascii.GetString(bytes);
            return str.Equals(value);
        }
    }
}
