
using System.Security.Cryptography;

public class Product
{
    //fields
    private int productID;
    private string productName;
    private double cost;
    public double tax;
    private int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    //constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    //setter method
    public void SetProductId(int value)
    {
        productID = value;
    }

    //getter method
    public int GetProductID()
    {
        return productID;
    }

    public void SetProductName(string value)
    {
        productName = value;
    }
    public string GetProductName()
    {
        return productName;
    }
    public void SetCost(double value)
    {
        cost = value;
    }
    public double GetCost()
    {
        return cost;
    }

    public void SetquantityInStock(int value)
    {
        quantityInStock = value;
    }
    public int GetquantityInStock()
    {
        return quantityInStock;
    }

    //static method to calculate total quantity
    public static int GetTotalQuantity( Product p1 ,Product  p2 ,Product  p3)
    {
        int total;
        total= p1.GetquantityInStock() + p2.GetquantityInStock() + p3.GetquantityInStock();
        return total;
    }
    //method
    public void CalculateTax()
    {
        double t;
        if (cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12.5 / 100;
        }
        tax = t;
    }
}
