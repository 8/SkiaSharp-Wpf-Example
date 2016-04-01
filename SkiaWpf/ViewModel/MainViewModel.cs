using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using SkiaWpf.Service;
using System.Windows.Media.Imaging;

namespace SkiaWpf.ViewModel
{
  public interface IMainViewModel : INotifyPropertyChanged
  {
    string Name { get; }
    ImageSource ImageSource { get; }
  }

  public class MainViewModel : BaseViewModel, IMainViewModel
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
    private readonly WriteableBitmap WriteableBitmap;

    public MainViewModel(IImageService imageService)
    {
      if (imageService == null)
        throw new ArgumentNullException(nameof(imageService));

      this.Name = "SkiaSharp Wpf Example";

      this.ImageService = imageService;
      this.ImageSource = this.WriteableBitmap = imageService.CreateImage(900, 600);
      CompositionTarget.Rendering += (o, e) => this.ImageService.UpdateImage(this.WriteableBitmap);
    }

  }
}
