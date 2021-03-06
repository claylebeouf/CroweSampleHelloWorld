using HelloWorldWithRest.Models;
using System;
using HelloWorldWithRest.Services;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldWithRest.Services.Tests
{
    /// <summary>This class contains parameterized unit tests for ApiRepository</summary>
    [TestClass]
    [PexClass(typeof(ApiRepository))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ApiRepositoryTest
    {

        /// <summary>Test stub for Get()</summary>
        [PexMethod]
        public HelloWorldViewModel.HelloWorldModel.Message GetTest()
        {
            HelloWorldViewModel.HelloWorldModel.Message result = ApiRepository.Get();
            return result;
            // TODO: add assertions to method ApiRepositoryTest.GetTest()
        }
    }
}
