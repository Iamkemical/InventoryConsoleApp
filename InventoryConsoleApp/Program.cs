using InventoryConsoleApp.DataAccess;
using InventoryConsoleApp.Repository;

class Program
{
    static void Main(string[] args)
    {
        CustomerRepository customerRepo = new();
        Console.WriteLine("***Welcome to Angela's Customer Inventory App***\n");
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Enter 1 to Add Customer");
            Console.WriteLine("Enter 2 to Update Customer");
            Console.WriteLine("Enter 3 to Delete Customer");
            Console.WriteLine("Enter 4 to Display all customers");
            Console.WriteLine("Enter 5 to quit");

            var stringInput = Console.ReadLine();

            int.TryParse(stringInput, out var input);

            switch (input)
            {
                case 1:
                    customerRepo.Create();
                    break;
                case 2:
                    customerRepo.Update();
                    break;
                case 3:
                    customerRepo.Delete();
                    break;
                case 4:
                    customerRepo.DisplayAll();
                    break;
                case 5:
                    loop = false;
                    break;
                default:
                    break;
            }
        }
        
    }
}