using jeudontestleheros.Web.UI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsWebUI
{
    [TestClass]
    public class HomeControllerUnitTest
    {
        [TestMethod]
        public void TestAboutIsOK()
        {
            HomeController controller = new HomeController();

            var result = controller.About();

            Assert.IsInstanceOfType(result, typeof(ViewResult));
            ViewResult viewResult = result as ViewResult;

            Assert.IsNotNull(viewResult.ViewData["Message"]);
            Assert.IsTrue(viewResult.ViewData["Message"].ToString() == "Your application description page.");

        }
    }
}
