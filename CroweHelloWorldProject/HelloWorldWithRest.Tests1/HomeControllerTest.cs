using System.Threading.Tasks;
using System.Web.Mvc;
using System;
using HelloWorldWithRest.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldWithRest.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for HomeController</summary>
    [TestClass]
    [PexClass(typeof(HomeController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class HomeControllerTest
    {

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public Task<ActionResult> IndexTest([PexAssumeUnderTest]HomeController target)
        {
            Task<ActionResult> result = target.Index();
            return result;
            // TODO: add assertions to method HomeControllerTest.IndexTest(HomeController)
        }
    }
}
