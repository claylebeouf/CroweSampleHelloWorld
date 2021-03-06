using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldWithRest.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="HelloWorldControllerTest.ConstructorTest.g.cs" company="Microsoft">Copyright © Microsoft 2018</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace HelloWorldWithRest.Controllers.Tests
{
    public partial class HelloWorldControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(HelloWorldControllerTest))]
public void ConstructorTest310()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      HelloWorldController helloWorldController;
      helloWorldController = this.ConstructorTest();
      disposables.Add((IDisposable)helloWorldController);
      disposables.Dispose();
      Assert.IsNotNull((object)helloWorldController);
      Assert.IsNotNull((object)(helloWorldController.apiRepository));
      Assert.IsNotNull(((ApiController)helloWorldController).ActionContext);
      Assert.IsNull
          (((ApiController)helloWorldController).ActionContext.ControllerContext);
      Assert.IsNull
          (((ApiController)helloWorldController).ActionContext.ActionDescriptor);
      Assert.IsNotNull
          (((ApiController)helloWorldController).ActionContext.ModelState);
      Assert.IsNotNull
          (((ApiController)helloWorldController).ActionContext.ActionArguments);
      Assert.IsNotNull
          (((ApiController)helloWorldController).ActionContext.ActionArguments
             .Comparer);
      Assert.AreEqual<int>(0, 
                           ((ApiController)helloWorldController).ActionContext.ActionArguments.Count);
      Assert.IsNull(((ApiController)helloWorldController).ActionContext.Response);
    }
}
    }
}
