using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkiaWpf.Factory;
using SkiaWpf.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaWpf.Test.Factory
{
  [TestClass]
  public class LocatorFactoryTest
  {
    private ILocatorFactory GetFactory()
    {
      return new IoCContainerFactory().GetContainer()
        .Resolve<ILocatorFactory>();
    }

    [TestMethod]
    public void LocatorFactory_Ctor()
    {
      GetFactory();
    }

    [TestMethod]
    public void LocatorFactory_AccessViewModel()
    {
      var factory = GetFactory();
      dynamic locator = factory.GetLocator();
      IMainViewModel vm = locator.MainViewModel as IMainViewModel;
    }
  }
}
