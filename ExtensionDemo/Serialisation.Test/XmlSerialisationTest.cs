using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Serialisation.Test
{
    [TestClass]
    public class XmlSerialisationTest
    {
        [TestMethod]
        public void XmlSerialisationNull()
        {
            object o = null;
            Assert.AreEqual(string.Empty, o.Serialize());
        }

        [TestMethod]
        public void XmlSerialisationString()
        {
            string test = "test";
            string result = test.Serialize();
            string expectedXml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<string>test</string>";
            Assert.AreEqual(expectedXml, result);
        }
    }
}
