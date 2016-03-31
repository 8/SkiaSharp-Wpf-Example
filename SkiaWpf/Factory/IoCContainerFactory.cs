using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyIoC;

namespace SkiaWpf.Factory
{
  public interface IIoCContainerFactory
  {
    TinyIoCContainer GetContainer();
  }

  public class IoCContainerFactory : IIoCContainerFactory
  {
    public TinyIoCContainer GetContainer()
    {
      var container = new TinyIoCContainer();
      container.AutoRegister();

      return container;
    }
  }
}
