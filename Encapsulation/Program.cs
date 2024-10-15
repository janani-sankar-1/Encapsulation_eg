class Sample
{
    static void Main()
    {
        //local constant
        const string developerName = "Janani";

        //reference variable
        Product p1, p2, p3;

        //create objects
        p1 = new Product();
        Product.TotalNoProducts++;
        p2 = new Product();
        Product.TotalNoProducts++;
        p3 = new Product();
        Product.TotalNoProducts++;

        //Initialize fields
        p1.SetProductId(1001);
        p1.SetProductName("Mobile");
        p1.SetCost(20000);
        p1.SetquantityInStock( 1200);

        p2.SetProductId(1002);
        p2.SetProductName("Laptop");
        p2.SetCost (30000);
        p2.SetquantityInStock ( 800);

        p3.SetProductId (1003);
        p3.SetProductName ("Speakers");
        p3.SetCost (2000);
        p3.SetquantityInStock (500);

        p1.CalculateTax();
        p2.CalculateTax();
        p3.CalculateTax();

        System.Console.WriteLine(developerName);
        //get values from fields
        System.Console.WriteLine("ProductID : " + p1.GetProductID());
        System.Console.WriteLine("ProductName : " + p1.GetProductName());
        System.Console.WriteLine("cost : " + p1.GetCost());
        System.Console.WriteLine("quantity : " + p1.GetquantityInStock());
        System.Console.WriteLine("Date Of Purchase : " + p1.dateOfPurchase);
        System.Console.WriteLine("Tax : " + p1.tax);
        System.Console.WriteLine();

        System.Console.WriteLine("ProductID : " + p2.GetProductID());
        System.Console.WriteLine("ProductName : " + p2.GetProductName());
        System.Console.WriteLine("cost : " + p2.GetCost());
        System.Console.WriteLine("quantity : " + p2.GetquantityInStock());
        System.Console.WriteLine("Date Of Purchase : " + p1.dateOfPurchase);
        System.Console.WriteLine("Tax : " + p2.tax);
        System.Console.WriteLine();

        System.Console.WriteLine("ProductID : " + p3.GetProductID());
        System.Console.WriteLine("ProductName : " + p3.GetProductName());
        System.Console.WriteLine("cost : " + p3.GetCost());
        System.Console.WriteLine("quantity : " + p3.GetquantityInStock());
        System.Console.WriteLine("Date Of Purchase : " + p1.dateOfPurchase);
        System.Console.WriteLine("Tax : " + p3.tax);
        System.Console.WriteLine();

        int totalQuantity = Product.GetTotalQuantity(p1, p2, p3);
        //int totalQuanity=p1.GetquantityInStock() + p2.GetquantityInStock() + p3.GetquantityInStock();
        System.Console.WriteLine("Total Quantity : " + totalQuantity);
        System.Console.WriteLine("Total product : " + Product.TotalNoProducts);
        System.Console.WriteLine("Category Name : " + Product.CategoryName);

        System.Console.ReadKey();

    }
}