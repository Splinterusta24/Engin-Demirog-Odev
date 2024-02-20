using Intro.Business;
using Intro.Entities;
using MyIntro.DataAccess.Concretes;

InduvidualCustomer customer = new InduvidualCustomer();
customer.Id = 1;
customer.FirstName = "Kaan";
customer.LastName = "akbas";
customer.NationalIdentiy = "123456789123";
customer.CustomerNumber = "123456";

InduvidualCustomer customer1 = new InduvidualCustomer();
customer1.Id = 2;
customer1.FirstName = "Nedim";
customer1.LastName = "Durmus";
customer1.NationalIdentiy = "56789012342";
customer1.CustomerNumber = "2135879";
CorporateCustomer corporateCustomer = new CorporateCustomer();
corporateCustomer.Id = 3;
corporateCustomer.Name = "halil";
corporateCustomer.CustomerNumber = "2311234";
corporateCustomer.TaxNumber = "231231";
BaseCustomer[] baseCustomers = { customer, corporateCustomer, customer1 };
foreach (BaseCustomer item in baseCustomers)
{
    Console.WriteLine(item.Id);
}

CourseManager courseManager = new(new EfCourseDal());
List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}