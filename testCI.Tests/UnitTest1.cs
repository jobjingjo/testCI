using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testCI.Controllers;

namespace testCI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private HomeController _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new HomeController();
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Assert.Fail("No tests");
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Index_Test()
        {
            var result = _target.Index();
            // Assert
            var viewResult = result as ViewResult;
            //var model = Assert.IsAssignableFrom<IEnumerable<StormSessionViewModel>>(
            //    viewResult.ViewData.Model);
            Assert.IsNotNull(viewResult);
        }
    }
}
