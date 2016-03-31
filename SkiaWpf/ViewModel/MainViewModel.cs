using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using SkiaWpf.Service;

namespace SkiaWpf.ViewModel
{
  public interface IMainViewModel : INotifyPropertyChanged
  {
    string Name { get; }
    ImageSource ImageSource { get; }
  }

  public class MainViewModel : BaseViewModel
  {
    #region ImageSource
    private ImageSource _ImageSource;
    public ImageSource ImageSource
    {
      get { return _ImageSource; }
      set
      {
        if (_ImageSource != value)
        {
          _ImageSource = value;
          OnPropertyChanged(nameof(ImageSource));
        }
      }
    }
    #endregion

    public string Name { get; private set; }

    private readonly IImageService ImageService;

    public MainViewModel(IImageService imageService)
    {
      if (imageService == null)
        throw new ArgumentNullException(nameof(imageService));

      this.Name = "SkiaSharp Wpf Example";

      this.ImageService = imageService;

      this.ImageSource = imageService.RenderImage();
    }
  }
}
