using System.Data;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewTheMainDepartmentsInTheStore))]
    public class ViewTheMainDepartmentsInTheStoreSpecs
    {
        public abstract class concern : Observes<IPerformApplicationBehaviour,
                                            ViewTheMainDepartmentsInTheStore>
        {
        }

        public class when_processing_a_request : concern
        {
          Establish c = () =>
          {
            request = fake.an<IContainRequestInformation>();
            depends.on<RequestCriteria>(x => true);
            application_behaviour = depends.on<IPerformApplicationBehaviour>();
            cmd = depends.on<IDbCommand>();

          };

          Because b = () =>
              sut.process(request);


          It should_get_a_list_of_the_main_departments_in_the_store = () =>
          {
            cmd.received(x => x.ExecuteReader());
          };
          
          static IContainRequestInformation request;
          static IPerformApplicationBehaviour application_behaviour;
          static IDbCommand cmd;

        }
    }
}