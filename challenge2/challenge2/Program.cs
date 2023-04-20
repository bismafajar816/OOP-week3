using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge2;

namespace challenge2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Products p = new Products();
            List<Products> obj = new List<Products>();
            int choice = Menu();
            while (choice != 0)
            {
                if (choice == 1)
                {
                    Console.Clear();
                    
                        p.AddProduct(obj);
                    
                    choice = Menu();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    p.Print(obj);
                    choice = Menu();
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    p.HighestUnitPrice(obj);
                    choice = Menu();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                   float taxes =  p.calculate_sales_tax(obj);
                    Console.WriteLine("Tax you have to pay is: " + taxes);

                    choice = Menu();
                }
                else if (choice == 5)
                {
                    Console.Clear();
                    p.OrderNeed(obj);
                    choice = Menu();
                }

            }
            Console.ReadKey();
        }
        static int Menu()
        {
            Console.WriteLine("1. Add Product.");
            Console.WriteLine("2. View Products.");
            Console.WriteLine("3. Calculate Tax.");
            Console.WriteLine("4. View product with Highest Unit Price.");
            Console.WriteLine("5. View the product to be Ordered.");
            Console.WriteLine(" Your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
