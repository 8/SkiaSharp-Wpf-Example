using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaWpf.ViewModel
{
  public class BaseViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
      => this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
    
    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
      => this.PropertyChanged?.Invoke(this, e);
  }
}
