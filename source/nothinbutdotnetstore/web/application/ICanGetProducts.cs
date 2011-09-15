using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nothinbutdotnetstore.web.application
{
  public interface ICanGetProducts
  {
    IEnumerable<Product> get_the_products_in(Department department);
  }
}
