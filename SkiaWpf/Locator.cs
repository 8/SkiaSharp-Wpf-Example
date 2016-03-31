using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaWpf
{
  /// <summary>Locator that forwards property access to the Dependency Resolver</summary>
  public class Locator : DynamicObject
  {
    /// <summary>Gets or sets the resolver that is used to map a property access to an instance</summary>
    public Func<string, object> Resolver { get; set; }

    public Locator()
    {
    }
    public Locator(Func<string, object> resolver)
    {
      this.Resolver = resolver;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
      bool successful;

      string property = binder.Name;

      var resolver = this.Resolver;

      if (resolver != null)
      {
        try
        {
          result = resolver(property);
          successful = true;
        }
        catch { result = null; successful = false; }
      }
      else
      {
        result = null;
        successful = false;
      }

      return successful;
    }

  }
}
