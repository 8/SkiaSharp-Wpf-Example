using SkiaWpf.Factory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace SkiaWpf
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private void Application_Startup(object sender, StartupEventArgs e)
    {
      this.Resources["Locator"] = new LocatorFactory(new IoCContainerFactory()).GetLocator();
    }
  }
}
