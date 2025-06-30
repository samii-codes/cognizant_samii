public class Product
{
    public int productId;
    public string productName;
    public string category;

    public Product(int projectId, string productName, string category)
    {
        this.productId = projectId;
        this.productName = productName;
        this.category = category;
    }

    public void DisplayProduct()
    {
        Console.WriteLine("Product ID: " + productId);
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Category: " + category);
    }

    
}


class SearchLogic
{
    public int linearSearchByID(Product[] product, int id)
    {
        for (int i = 0; i < product.Length; i++)
        {
            if (product[i].productId == id)
            {
                return i;
            }
        }
        return -1;
    }
    public int linearSearchByName(Product[] product, string name)
    {
        for (int i = 0; i < product.Length; i++)
        {
            if (product[i].productName.ToLower() == name)
            {
                return i;
            }
        }
        return -1;
    }

    public int binarySearchByID(Product[] product, int id)
    {
        Array.Sort(product, (a, b) => a.productId.CompareTo(b.productId));
        int low = 0;
        int high = product.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (product[mid].productId == id)
            {
                return mid;
            }
            else if (product[mid].productId < id)
            {
                low = mid + 1;
            }
            else if (product[mid].productId > id)
            {
                high = mid - 1;
            }
        }
        return -1;
    }

    public int binarySearchByName(Product[] product, string name)
    {
        Array.Sort(product, (a, b) => a.productName.CompareTo(b.productName));
        int low = 0;
        int high = product.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int comparison = product[mid].productName.ToLower().CompareTo(name);
            if (comparison == 0)
            {
                return mid;
            }
            else if (comparison < 0)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }

        }
        return -1;
    }

    
}

public class Program
{
    public static void Main(string[] args)
    {
        Product[] product = new Product[]{
        new Product(1, "Laptop", "Electronics"),
        new Product(10, "Mobile", "Electronics"),
        new Product(12, "Umbrella", "Accessories"),
        new Product(15, "Shoes", "Footwear"),
        new Product(25, "Shirt", "Clothing"),
        new Product(20, "Saridon", "Medicine")
        };
        SearchLogic search = new SearchLogic();
        Console.WriteLine("Search can be done  in two ways:\n1.Name\n2.ID\nEnter your choice:");
        string choice = Console.ReadLine()!.ToLower();
        if (choice == "1" || choice=="name")
        {
            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine()!.ToLower();
            Console.WriteLine("\n---------Using Linear Search Algorithm----------\n");
            int linearIndex = search.linearSearchByName(product, name);
            if (linearIndex != -1)
            {
                product[linearIndex].DisplayProduct();
            }
            else
            {
                Console.WriteLine("Product not found");
            }

            int binaryIndex = search.binarySearchByName(product, name);
            Console.WriteLine("\n---------Using Binary Search Algorithm----------\n");
            if (binaryIndex != -1)
            {
                product[binaryIndex].DisplayProduct();
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }
        else if (choice == "2"||choice == "id")
        {
            Console.WriteLine("Enter product ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            int linearIndex = search.linearSearchByID(product, id);
            Console.WriteLine("\n---------Using Linear Search Algorithm----------\n");
            if (linearIndex != -1)
            {
                product[linearIndex].DisplayProduct();
            }
            else
            {
                Console.WriteLine("Product not found");
            }

            int binaryIndex = search.binarySearchByID(product, id);
            Console.WriteLine("\n---------Using Binary Search Algorithm----------\n");
            if (binaryIndex != -1)
            {
                product[binaryIndex].DisplayProduct();
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

         

    }
}