using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("Outubro","Matola","Maputo", "Mocambique");
        Customer customer1 = new Customer("Mafuwe Manuel",address1);


        Product product1 = new Product("laranjas", 9384, 7, 23);
        
        Order order1 = new Order(customer1,product1);
               

        //Console.WriteLine(customer1);
        Console.WriteLine(order1);
    }
}