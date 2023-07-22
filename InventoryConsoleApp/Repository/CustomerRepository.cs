using InventoryConsoleApp.DataAccess;
using InventoryConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryConsoleApp.Repository;
public class CustomerRepository
{
    private readonly CustomerDb _db;
    public CustomerRepository()
    {
        _db = new CustomerDb();
    }

    public void Create()
    {
        Console.Write("Enter Id: ");
        var idInput = Console.ReadLine();
        int.TryParse(idInput, out var customerId);

        Console.Write("Enter Name: ");
        var nameInput = Console.ReadLine();

        Console.Write("Enter Age: ");
        var ageInput = Console.ReadLine();
        int.TryParse(ageInput, out var age);

        _db.Add(new Customer { Id = customerId, Name = nameInput, Age = age });
    }

    public void Update()
    {
        Console.Write("Enter Id: ");
        var idInput = Console.ReadLine();
        int.TryParse(idInput, out var customerId);

        Console.Write("Enter Name: ");
        var nameInput = Console.ReadLine();

        Console.Write("Enter Age: ");
        var ageInput = Console.ReadLine();
        int.TryParse(ageInput, out var age);

        Console.Write("Enter IsEnrolled: ");
        var isEnrolledInput = Console.ReadLine();
        bool.TryParse(isEnrolledInput, out var isEnrolled);

        _db.Update(new Customer { Id = customerId, Name = nameInput, Age = age, IsEnrolled = isEnrolled });
    }

    public void Delete()
    {
        Console.Write("Enter Id: ");
        var idInput = Console.ReadLine();
        int.TryParse(idInput, out var customerId);

        _db.Delete(customerId);
    }

    public void DisplayAll()
    {
        _db.GetAll();
    }
}
