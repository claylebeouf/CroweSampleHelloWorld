using System;
using HelloWorldWithRest.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldWithRest.Models.Tests
{
    /// <summary>This class contains parameterized unit tests for HelloWorldViewModel</summary>
    [TestClass]
    [PexClass(typeof(HelloWorldViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class HelloWorldViewModelTest
    {
    }
}
