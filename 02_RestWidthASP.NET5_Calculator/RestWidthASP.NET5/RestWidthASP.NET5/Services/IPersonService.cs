using RestWidthASP.NET5.Model;
using System.Collections.Generic;

namespace RestWidthASP.NET5.Services
{
    public interface IPersonService
    {

        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

    }
}
