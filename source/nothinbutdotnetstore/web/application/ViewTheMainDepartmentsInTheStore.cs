using System.Data;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class ViewTheMainDepartmentsInTheStore : IPerformApplicationBehaviour
    {
      IDbCommand command;
      public ViewTheMainDepartmentsInTheStore(IDbCommand command)
      {
        this.command = command;
      }

      public void process(IContainRequestInformation request)
      {
        //using(IDataReader reader = command.ExecuteReader())
        //{

        //}
      }
    }
}