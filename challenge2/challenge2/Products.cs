using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2
{
    class Products
    {
        public List<Products> items = new List<Products>();
        public Products()
        {
            name = " ";
            category = " ";
            price = 0;
            stock = 0;
            minStock = 0;
        }
        public Products(string name, string category, float price, int stock, int minStock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stock = stock;
            this.minStock = minStock;

        }
        public void Print(List<Products> p)
        {
            for(int i = 0; i < p.Count(); i++)
            {
                Console.Write("Name: " + p[i].name + "\n  category " + p[i].category + "\n  price  " + p[i].price + " \n  stock " + p[i].stock + " \n minimum stock " + p[i].minStock);
            }
          
        }
        public void AddProduct(List<Products> items)
        {

            Products obj = new Products();
            Console.WriteLine("Enter the name of product: ");
            obj.name = Console.ReadLine();
            Console.WriteLine("Enter the category of products grocery, fruit or other :");
            obj.category = Console.ReadLine();
            Console.WriteLine("Enter the price of the item: ");
            obj.price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the quantity of product: ");
            obj.stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minimum quantity of product: ");
            obj.minStock = int.Parse(Console.ReadLine());
            items.Add(obj);
            Console.WriteLine("Item added");
              

        }
        public void HighestUnitPrice(List<Products> p)
        {
            int largest = 0;
            for(int i = 0; i < p.Count(); i++)
            {
                if(p[largest].price < p[i].price)
                {
                    largest = i;
                }

            }
            Console.WriteLine("THE PRODUCT WITH HIGHEST UNIT PRICE ");
            Console.WriteLine("Name: " + p[largest].name);
            Console.WriteLine("Category: " + p[largest].category);
            Console.WriteLine("Price: " + p[largest].price);
            Console.WriteLine("Stock: " + p[largest].stock);
            Console.WriteLine("Min Stock:" + p[largest].minStock);
        }
        public float calculate_sales_tax(List<Products> items)
        {
            float tax = 0.0F;
            for(int x = 0; x < items.Count(); x++)
            {
                if (items[x].category == "groceries")
                {
                    tax =items[x].price * 0.1F;
                }
                else if (category == "fruit")
                {
                   tax = items[x].price * 0.05F;
                }
                else
                {
                   tax = items[x].price * 0.15F;
                }
               
            }
            return tax;


        }
        public void OrderNeed(List<Products> p)
        {
            bool flag = false;
            int largest = 0;
            for (int i = 0; i < p.Count(); i++)
            {
                if (p[i].stock < p[i].minStock)
                {
                    largest = i;
                    flag = true;
                }

            }
            if (flag== true)
            {
                Console.WriteLine("THE PRODUCT THAT IS TO BE ORDERED IS");
                Console.WriteLine("Name: " + p[largest].name);
                Console.WriteLine("Category: " + p[largest].category);
                Console.WriteLine("Price: " + p[largest].price);
                Console.WriteLine("Stock: " + p[largest].stock);
                Console.WriteLine("Min Stock:" + p[largest].minStock);

            }
            else
            {
                Console.WriteLine("No product is out of stock");
            }

           
        }

        public string name;
        public string category;
        public float price;
        public int minStock;
        public int stock;
    }
}
