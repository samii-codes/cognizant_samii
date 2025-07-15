using System;
using System.Collections;

public class Product
{
    public int productID;
    public string productName;
    public int quantity;
    public int price;

    public Product(int productID, string productName, int quantity, int price)
    {
        this.productID = productID;
        this.productName = productName;
        this.quantity = quantity;
        this.price = price;
    }

    public void DisplayProduct()
    {
        Console.WriteLine("Product ID: " + productID);
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Price: " + price);
    }
}

public class Elements
{
    ArrayList products = new ArrayList();

    public string Add(Product product)
    {
        foreach (Product p in products)
        {
            if (p.productID == product.productID)
            {
                return $"Product with ID {product.productID} already Exists.You can update or delete it.";
            }
        }
        products.Add(product);
        return $"Product with ID {product.productID} is added to the ArrayList";
    }

    public string Update(int ID, string? name = null, int? quantity = null, int? price = null)
    {
        foreach (Product p in products)
        {
            if (p.productID == ID)
            {
                if (name != null)
                {
                    p.productName = name;
                }
                if (quantity != null)
                {
                    p.quantity = quantity.Value;
                }
                if (price != null)
                {
                    p.price = price.Value;
                }
                return "Product updated successfully";
            }

        }
        return $"Product {ID} not found!Updation failed";
    }

    public string Delete(int ID)
    {
        int i = 0;
        foreach (Product p in products)
        {
            if (p.productID == ID)
            {
                products.RemoveAt(i);
                return "Element removed from the ArrayList";
            }
            i++;
        }
        return "Element not found";
    }

    public void Display()
    {
        foreach (Product p in products)
        {
            Console.WriteLine($"\nProduct ID: {p.productID}\nProduct Name: {p.productName}\nQuantity: {p.quantity}\nPrice: {p.price}");
        }
    }

}


public class Program
{
    public static void Main(string[] args)
    {
        Elements elements = new Elements();
        Console.WriteLine("\n");
        Console.WriteLine(elements.Add(new Product(1, "Product 1", 10, 1000)));
        Console.WriteLine(elements.Add(new Product(2, "Product 2", 20, 2000)));
        Console.WriteLine(elements.Add(new Product(3, "Product 3", 30, 3000)));

        Console.WriteLine(elements.Update(2, "Updated Product 2", 25, 2500));
        Console.WriteLine(elements.Delete(2));

        Console.WriteLine("------------------------------------------------------");

        elements.Display();
    }
}
