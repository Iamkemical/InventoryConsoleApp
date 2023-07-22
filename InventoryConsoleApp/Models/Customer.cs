using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryConsoleApp.Models;
public class Customer
{
    public Customer() { }

    public Customer(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsEnrolled { get; set; } = true;
}

//public record Customer(int Id, string Name, int Age, bool IsEnrolled = true);