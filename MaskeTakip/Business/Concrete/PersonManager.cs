using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

      
    public class PersonManager : IApplicationService
    {
        void IApplicationService.ApplicationForMask(Person person)
        {
            throw new NotImplementedException();
        }


        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateofBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Person>GetList()
        {
            Person person=new Person();
            person.FirstName = "İrem";
            person.LastName = "Gümüş";
            person.DateofBirthYear = new DateTime(1996,10,01);
            person.NationalIdentity = 122256493;

            List<Person> list = new List<Person>(); 
            list.Add(person);

            return list ;
        }

    }
}
