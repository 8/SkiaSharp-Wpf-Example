using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkiaWpf.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkiaWpf.ViewModel;

namespace SkiaWpf.Factory.Test
{
  [TestClass]
  public class IoCContainerFactoryTest
  {
    IIoCContainerFactory GetFactory()
    {
      return new IoCContainerFactory();
    }

    [TestMethod]
    public void IoCContainerFactoryTest_Ctor()
    {
      GetFactory();
    }

    [TestMethod]
    public void IoCContainerFactoryTest_GetContainer()
    {
      var factory = GetFactory();
      var container = factory.GetContainer();
    }

    [TestMethod]
    public void IoCContainerFactoryTest_ResolveViewModels()
    {
      var vm = GetFactory().GetContainer().Resolve<MainViewModel>();
    }

  }
}
