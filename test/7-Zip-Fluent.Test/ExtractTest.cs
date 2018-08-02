using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SevenZipFluent.Test
{
    [TestClass]
    public class ExtractTest
    {
        [TestMethod]
        public void ExtractWithCustomDirectory()
        {
            SevenZipBuilder builder = new SevenZipBuilder();
            var cmd = builder.CreateSevenCmd()
                .Extract()
                .OutputDirectory(@"c:\windows\temp")
                .Build();

            Assert.AreEqual(@"7z.exe e -o""c:\windows\temp""", cmd);
        }
    }
}
