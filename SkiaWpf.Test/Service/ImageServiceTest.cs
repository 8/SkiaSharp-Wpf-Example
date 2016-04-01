using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkiaWpf.Service;

namespace SkiaWpf.Test.Service
{
  [TestClass]
  public class ImageServiceTest
  {
    IImageService GetService()
    {
      return new ImageService();
    }

    [TestMethod]
    public void ImageServiceTest_Ctor()
    {
      GetService();
    }

    [TestMethod]
    public void ImageServiceTest_CreateImage()
    {
      var image = GetService().CreateImage(800, 600);
    }

    [TestMethod]
    public void ImageServiceTest_RenderImage()
    {
      var service = GetService();
      var image = service.CreateImage(800, 600);
      service.UpdateImage(image);
    }
  }
}
