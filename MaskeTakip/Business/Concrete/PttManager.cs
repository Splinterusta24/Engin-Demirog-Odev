using Business.Abstract;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Concrete
{
    public class PttManager:ISupplierService
    {
        // interfaceleri kullanacagimiz zaman ilk başta field dediğimiz interface türünde değişken tanımlarız
        // bunuda global alanda ulaşabilelim diye yapıyoruz
        // --buraya dikkat-- constructorlar newlendiğinde çaılışır o yüzden set ederiz ve interfaceler referans türlüdür.
        // sonra istediğimiz method ya da classta kullanırız mesela 20. satirda 


        private IApplicationService _applicationService;
        
        public PttManager(IApplicationService applicationService)//constructor new yapıldığında çalışır
        {
            _applicationService = applicationService;
        }

        public void GiveMask(Person person)
        {
            if (_applicationService.CheckPerson(person))
            {

                Console.WriteLine(person.FirstName + "için maske verildi.");

            }
            else
            {
                Console.WriteLine("Yanlış Bilgi Verildi");
            }
        }
    }
}
