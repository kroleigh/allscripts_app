using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application
{
  public class ViewProductsInADepartment : IPerformApplicationBehaviour
  {

    ICanGetProducts products_repository;
        IDisplayReports display_engine;

        public ViewProductsInADepartment(ICanGetProducts product_repository, IDisplayReports display_engine)
        {
          this.products_repository = product_repository;
            this.display_engine = display_engine;
        }

        public ViewProductsInADepartment()
          : this(new StubProductRepository(),
            new StubDisplayEngine())
        {
        }

        public void process(IContainRequestInformation request)
        {
          display_engine.display(products_repository.get_the_products_in(request.map<Department>()));
        }
  }
}
