using InventoryConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryConsoleApp.DataAccess;
public class CustomerDb
{
    private readonly List<Customer> _customerBuffer;
    public CustomerDb()
    {
        _customerBuffer = new List<Customer>();
    }

    public void Add(Customer customer)
    {
        var existingCustomer = GetCustomerById(customer.Id);
        if (existingCustomer != null)
        {
            Console.WriteLine($"Customer with {customer.Id} already exists!");
            return;
        }
        _customerBuffer.Add(customer);
    }

    public void Delete(int id)
    {
        var existingCustomer = GetCustomerById(id);
        if (existingCustomer == null)
        {
            Console.WriteLine("Customer does not exist!"); 
            return;
        }
        _customerBuffer.Remove(existingCustomer);
        Console.WriteLine("Customer successfully removed!");
    }

    public void Update(Customer customer)
    {
        var existingCustomer = GetCustomerById(customer.Id);
        if (existingCustomer == null)
        {
            Console.WriteLine("Customer does not exist!"); 
            return;
        }
        foreach (var item in _customerBuffer)
        {
            if(item.Id == existingCustomer.Id)
            {
                item.Name = customer.Name;
                item.Age = customer.Age;
                item.IsEnrolled = customer.IsEnrolled;

                Console.WriteLine("Customer updated successfully");
            }
        }
    }

    public void GetAll()
    {
        foreach (var item in _customerBuffer)
        {
            Console.WriteLine($"Id: {item.Id} | Name: {item.Name} | Age: {item.Age} | IsEnrolled: {item.IsEnrolled}");
        }
    }

    private Customer? GetCustomerById(int id) => _customerBuffer.Where(c => c.Id == id).FirstOrDefault();
}
