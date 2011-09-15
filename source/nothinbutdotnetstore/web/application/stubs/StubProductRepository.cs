using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nothinbutdotnetstore.web.application.stubs
{
  public class StubProductRepository:ICanGetProducts
  {
 

    #region ICanGetProducts Members

    IEnumerable<Product> ICanGetProducts.get_the_products_in(Department department)
    {
      return Enumerable.Range(1, 199).Select(x => new Product { Name = x.ToString("product 0") });
    }

    #endregion
  }
}
