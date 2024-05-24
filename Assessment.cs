using C_Assessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assessment
{
    public class ConsoleApp
    {
        public static List<Product> products = new List<Product>();
        public static List<Product> cart = new List<Product>();
        public bool checkout = true;
        public ConsoleApp() 
        {
            products.Add(new Product { ProductId = 1, ProductName = "Shirt", ProductPrice = 750 });
            products.Add(new Product { ProductId = 2, ProductName = "TShirt", ProductPrice = 400 });
            products.Add(new Product { ProductId = 3, ProductName = "Trouser", ProductPrice = 1450 });
            products.Add(new Product { ProductId = 4, ProductName = "Handbag", ProductPrice = 2500 });
            products.Add(new Product { ProductId = 5, ProductName = "Socks", ProductPrice = 150 });
            products.Add(new Product { ProductId = 6, ProductName = "Shoes", ProductPrice = 3300 });
        }
            
    public void LoginPage()
        {
            Console.WriteLine("Welcome to Login Page");
            Console.WriteLine("Please enter username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter password : ");
            string password = Console.ReadLine();
            Login login = new Login();
            bool isLoggedIn = login.IsValidUser(username, password);
            if (isLoggedIn)
            {
                Console.WriteLine("Congralutions! You are loggedIn");
                Console.WriteLine("Please select from below products to Add in your cart!");
            }
            else
            {
                Console.WriteLine("Your username or password is incorrect");
            }

        }
        public void RegisterPage()
        {
            Console.WriteLine("Currently we don't have register feature. We are working on it!");
        }
        public void DisplayProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine("Product Id: {0}, Product Name: {1}, Product Price {2}", product.ProductId, product.ProductName, product.ProductPrice);
                Console.WriteLine();
            }
        }
        public void AddItemsToCart()
        {
            while (checkout)
            {
                Console.WriteLine("Please select a ProductId to add in your Cart!");
                int itemId = int.Parse(Console.ReadLine());
                cart.Add(products.Find(item => item.ProductId == itemId));
                Console.WriteLine("Item added in your cart!");
                Console.WriteLine();
                Console.WriteLine("Do you wish to continue or Checkout?");
                Console.WriteLine("Press 1 to continue");
                Console.WriteLine();
                Console.WriteLine("Press 2 to checkout");
                Console.WriteLine();
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        break;

                    case 2:
                        checkout = false;
                        break;
                }
            }
        }
        public void DisplayCart()
        {
            int total = 0;
            Console.WriteLine();
            Console.WriteLine("Your cart has below items");
            Console.WriteLine();
            foreach (var product in cart)
            {
                total += product.ProductPrice;
                Console.WriteLine("Product Id: {0}, Product Name: {1}, Product Price {2}", product.ProductId, product.ProductName, product.ProductPrice);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("The total amount due is : INR {0}",total );
        }

    }

    internal class Assessment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("            Welcome to ECommerce Console App                 ");
            Console.WriteLine("*************************************************************");
            Console.WriteLine();
            Console.WriteLine("Please select any of below options");
            Console.WriteLine("Press 1 to Login");
            Console.WriteLine("Press 2 to Register");
            Console.WriteLine();

            ConsoleApp app = new ConsoleApp();

            int option = int.Parse(Console.ReadLine());
            switch (option) 
            {
                case 1:
                    app.LoginPage();
                    break;
                case 2:
                    app.RegisterPage();
                    break;
                default:
                    Console.WriteLine("You have not selected a valid option");
                    break;
            }

            app.DisplayProducts();

            Console.WriteLine();

            app.AddItemsToCart();

            app.DisplayCart();
        }
    }
}
