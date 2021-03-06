// <copyright file="HelloWorldControllerTest.cs" company="Microsoft">Copyright © Microsoft 2018</copyright>
using System;
using HelloWorldWithRest.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldWithRest.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for HelloWorldController</summary>
    [PexClass(typeof(HelloWorldController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class HelloWorldControllerTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public HelloWorldController ConstructorTest()
        {
            HelloWorldController target = new HelloWorldController();
            return target;
            // TODO: add assertions to method HelloWorldControllerTest.ConstructorTest()
        }
    }
}
