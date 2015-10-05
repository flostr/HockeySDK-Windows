﻿namespace Microsoft.ApplicationInsights.Extensibility.Windows
{
    using Microsoft.ApplicationInsights.Extensibility;
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

    [TestClass]
    public class UserContextReaderTest
    {
        [TestMethod]
        public void StoreRegionReturnsATwoLettersRegion()
        {
            string storeRegion = UserContextReader.GetStoreRegion();
            Assert.AreEqual(storeRegion.Length, 2);
        }
    }
}
