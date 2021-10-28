using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTesting
{
    public class TestUserValid
    {
        [TestFixture]
        public class TugasLibraryTest
        {
            private User user;

            [SetUp]
            public void Init()
            {
                user = new User();
            }

            [Test]
            public void TestUserValid()
            {
                Assert.AreEqual(true, user.IsValidUser("admin", "admin"));
            }
        }
    }
}
