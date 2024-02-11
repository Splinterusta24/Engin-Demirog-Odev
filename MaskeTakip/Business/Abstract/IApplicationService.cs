using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicationService
    {
       public void ApplicationForMask(Person person);
       public  bool CheckPerson(Person person);
       public List<Person> GetList();
    }
}
