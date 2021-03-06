using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
// <copyright file="WebApiConfigTest.Register.g.cs" company="Microsoft">Copyright © Microsoft 2018</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace HelloWorldWithRest.Tests
{
    public partial class WebApiConfigTest
    {

[TestMethod]
[PexGeneratedBy(typeof(WebApiConfigTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void Register01()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      HttpRouteCollection httpRouteCollection;
      HttpConfiguration httpConfiguration;
      httpRouteCollection = new HttpRouteCollection("%");
      disposables.Add((IDisposable)httpRouteCollection);
      httpConfiguration = new HttpConfiguration(httpRouteCollection);
      httpConfiguration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Default;
      disposables.Add((IDisposable)httpConfiguration);
      this.Register(httpConfiguration);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(WebApiConfigTest))]
public void Register504()
{
    this.Register((HttpConfiguration)null);
}
    }
}
