using System;

namespace Product
{
    public class Product
    {
        public string prodName;
        public double price; 
        public int quantity;

        public Product(string name, double prc, int qty)
        {

            prodName = name;
            price = prc;
            quantity = qty;
        }
public void DisplayDetails()
{
    double totalBill ,price ,quantity;
    Console.WriteLine("Product Name :" + prodName);
    Console.WriteLine("Price : " + price);
    Console.WriteLine("Quantity" + quantity);
    Console.WriteLine("Total Bill Console.WriteLine:" + totalBill);



}

class TestProduct
    {
       
public static void Main(string[] args)
        {
            Console.WriteLine("=== PRODUCT DETAILS ==="); 
            Console.WriteLine("--\");
            Product p1 = new Product("Laptop", 45000, 1); 
            Product p2 = new Product("Mouse", 500, 3); 
            p1.DisplayDetails();
            p2.DisplayDetails(); Console.ReadKey();
        }

  
}
