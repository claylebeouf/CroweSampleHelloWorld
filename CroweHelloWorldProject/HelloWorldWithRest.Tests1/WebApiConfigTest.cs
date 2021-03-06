using System.Web.Http;
// <copyright file="WebApiConfigTest.cs" company="Microsoft">Copyright © Microsoft 2018</copyright>

using System;
using HelloWorldWithRest;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldWithRest.Tests
{
    [TestClass]
    [PexClass(typeof(WebApiConfig))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class WebApiConfigTest
    {

        [PexMethod(MaxConditions = 1000)]
        public void Register(HttpConfiguration config)
        {
            WebApiConfig.Register(config);
            // TODO: add assertions to method WebApiConfigTest.Register(HttpConfiguration)
        }
    }
}
