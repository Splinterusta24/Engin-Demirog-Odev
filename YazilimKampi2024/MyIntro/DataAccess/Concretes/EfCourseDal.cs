using Intro.Entities;
using MyIntro.DataAccess.Abstracts;

public class EfCourseDal:ICourseDal
{
    List<Course> courses;
    public EfCourseDal()
    {
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
        Course course = new Course
        {
            Id = 6,
            Name = "kana",
            Description = "hakan",
            Price = 76
        };

        Course course2 = new Course
        {
            Id = 2,
            Name = "tayfun",
            Description = "taksi",
            Price = 76
        };

        courses = new List<Course> { course, course2 };
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}