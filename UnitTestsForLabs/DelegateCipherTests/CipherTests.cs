using Delegates.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForLabs.DelegateCipherTests
{
    [TestClass]
    public class CipherTests
    {
        [TestMethod]
        public void SimpleCaesarCipher1SpaceTest()
        {
            string result = CaesarCipher.EncryptSimple1Step("my encypted string");
            Assert.AreEqual(result, "nz fodzqufe tusjoh");
        }

        [TestMethod]
        public void SimpleReverseCipherTest()
        {
            string result = CaesarCipher.ReverseEncryption("my encypted string");
            Assert.AreEqual(result, "gnirts detpycne ym");
        }
    }
}
