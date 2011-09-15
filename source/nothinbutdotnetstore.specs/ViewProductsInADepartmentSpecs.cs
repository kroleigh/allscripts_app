using System.Collections.Generic;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
  [Subject(typeof(ViewProductsInADepartment))]
  public class ViewProductsInADepartmentSpecs
  {
    public class concern : Observes<IPerformApplicationBehaviour, ViewProductsInADepartment>
    {

    }

    public class when_viewing_products : concern
    {

      //A
      Establish c = () =>
      {
         products = new List<Product> {new Product()};
         department = new Department();
         product_repository = depends.on<ICanGetProducts>();
         display_engine = depends.on<IDisplayReports>();
         request = fake.an<IContainRequestInformation>();
         product_repository.setup(x => x.get_the_products_in(department))
                    .Return(products);

          request.setup(x => x.map<Department>()).Return(department);
      };
      //A
      Because b = () =>
        sut.process(request);

      //A
        It should_return_products_in_department = () =>
          display_engine.received(x => x.display(department));


      static IEnumerable<Product> products;
      static Department department;
      static IDisplayReports display_engine;
      static ICanGetProducts product_repository;
      static IContainRequestInformation request;

    }
  }
}
