using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace SoaSandbox.Data.Test
{
    [TestClass]
    public class EntitiesAccessorTest
    {
        public String TestingConectionString = "testing connection string";

        public String TestingConectionString2 = "testing connection string 2";

        [TestInitialize]
        public void Setup()
        {
            File.Delete("./App.ConnectionString");
            using (var stream = File.CreateText("./App.ConnectionString"))
            {
                stream.WriteLine(this.TestingConectionString);
            }

            File.Delete("./App.ConnectionString2");
            using (var stream = File.CreateText("./App.ConnectionString2"))
            {
                stream.WriteLine(this.TestingConectionString2);
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            File.Delete("./App.ConnectionString");
            File.Delete("./App.ConnectionString2");
        }

        [TestMethod]
        public void ConnectionStringFilePathTestWithDefaultValue()
        {
            var accessor = new EntitiesAccessor();
            var actual = accessor.GetPrivateInstance<String>("_connectionString");
            var expected = this.TestingConectionString;

            Assert.AreEqual<String>(expected, actual);
        }

        [TestMethod]
        public void ConnectionStringFilePathTestWithValue()
        {
            var accessor = new EntitiesAccessor("App.ConnectionString2");
            var actual = accessor.GetPrivateInstance<String>("_connectionString");
            var expected = this.TestingConectionString2;

            Assert.AreEqual<String>(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException), AllowDerivedTypes = false)]
        public void ConnectionStringFilePathTestWithInvalidPath()
        {
            new EntitiesAccessor("invalid value");
        }
    }
}
