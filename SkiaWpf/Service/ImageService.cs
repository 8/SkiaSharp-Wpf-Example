using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SkiaWpf.Service
{
  public interface IImageService
  {
    ImageSource RenderImage();
  }

  class ImageService : IImageService
  {
    public ImageService()
    {
    }

    public ImageSource RenderImage()
    {
      int width = 900, height = 600;

      var writeableBitmap = new WriteableBitmap(width, height, 96, 96, PixelFormats.Bgra32, BitmapPalettes.Halftone256Transparent);

      writeableBitmap.Lock();

      using (var surface = SKSurface.Create(
        width: width,
        height: height,
        colorType: SKColorType.Bgra_8888,
        alphaType: SKAlphaType.Premul,
        pixels: writeableBitmap.BackBuffer,
        rowBytes: width * 4))
      {
        SKCanvas canvas = surface.Canvas;

        canvas.Clear(new SKColor(130, 130, 130));
        canvas.DrawText("SkiaSharp on Wpf!", 50, 200, new SKPaint() { Color = new SKColor(0, 0, 0), TextSize = 100 });
      }

      writeableBitmap.AddDirtyRect(new Int32Rect(0, 0, width, height));

      writeableBitmap.Unlock();

      return writeableBitmap;
    }
  }
}
