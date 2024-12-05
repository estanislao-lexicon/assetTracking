using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using OfficeNameSpace;
using MyDbContextNamespace;
using AssetNameSpace;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace assetTracking;

class Program
{
    static void Main(string[] args)
    {
        MyDbContext MyDb = new MyDbContext();
        PrintList(MyDb);
        
        bool run = true;
        while(run == true)
        {
            System.Console.WriteLine("\nPress 'A' if you want to create a new Asset, 'P' to print assets list or 'Q' if you want to quit.");
            System.Console.Write(">");
            string input = Console.ReadLine().ToUpper();

            if(input == "A")
            {
                NewAsset(MyDb);
            }
            else if(input == "P")
            {
                PrintList(MyDb);
            }
            else if(input == "Q")
            {
                run = false;
            }
            else
            {
                System.Console.WriteLine("Please enter a valid input");
            }
        }
    }

    public static void PrintList(MyDbContext MyDb)
    {
        DateTime dateNow = DateTime.Now;
        
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Gray;
        string headers = "Asset".PadRight(20) + "Brand".PadRight(20) + "Model".PadRight(20) + "Price(USD)".PadRight(20) + "Purchase Date".PadRight(20) + "\n";
        System.Console.WriteLine(headers);
        string divider = new string('-', headers.Length);
        System.Console.WriteLine(divider);
        Console.ResetColor();

        foreach(var asset in MyDb.Assets)        
        {
            DateTime purchaseDate = asset.PurchaseDate;
            var timeDifference = dateNow.Subtract(purchaseDate);            
            int experied = 1095 - timeDifference.Days;            

            if(experied <= 90)
            {
                Console.ForegroundColor = ConsoleColor.Red;                
            } 
            else if (experied <= 120)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;                
            }
            else
            { 
                Console.ForegroundColor = ConsoleColor.Gray;                
            }

            Console.WriteLine($"{asset.Type}".PadRight(20) + $"{asset.Brand}".PadRight(20) + $"{asset.Model}".PadRight(20) + $"{asset.Price}".PadRight(20) + $"{asset.PurchaseDate.ToString("dd-MM-yyyy")}".PadRight(20));            
        }
    }

    public static void NewAsset(MyDbContext MyDb)
    {            
        string type;
        while (true)
        {
            Console.WriteLine("Please enter the type of asset you want to create (Computer, Smartphone, etc):");
            Console.Write(">");
            type = Console.ReadLine();
                        
            if (!string.IsNullOrEmpty(type))
            {
                type = char.ToUpper(type[0]) + type.Substring(1).ToLower();
            }            
                       
            if (type != null)
            {
                break;
            }

            Console.WriteLine($"Asset type '{type}' is not recognized. Please ensure it is a valid class name.");
        }

        System.Console.WriteLine($"Please enter the brand of the {type}:");
        System.Console.Write(">");
        string brand = Console.ReadLine();

        System.Console.WriteLine($"Please enter the model of the {type}:");
        System.Console.Write(">");
        string model = Console.ReadLine();

        decimal price;    
        System.Console.WriteLine($"Please enter the price in USD of the {type}:");
        System.Console.Write(">");
        string input = Console.ReadLine();

        while (!decimal.TryParse(input, out price) || price <= 0)
        {
            Console.WriteLine("Invalid price. Please enter a numeric value greater than 0:");
            Console.Write(">");
            input = Console.ReadLine();
        }

        System.Console.WriteLine($"Please enter the purchase date (yyyy-mm-dd) of the {type}:");
        System.Console.Write(">");
        string purchaseDateString = Console.ReadLine();
        DateTime purchaseDate;

        if (!DateTime.TryParseExact(purchaseDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out purchaseDate))
        {
            Console.WriteLine("Invalid purchase date format. Asset creation aborted.");
            return;
        }

        System.Console.WriteLine($"Please enter the office where the {type} is located:");
        System.Console.Write(">");
        string office = Console.ReadLine();
        int officeId = 0;
        if (!string.IsNullOrEmpty(type))
        {
            if(office == "USA")
            {
                officeId = 1;
            } 
            else if (office == "Sweden")
            {
                officeId = 2;
            }
            else if (office == "Germany")
            {
                officeId = 3;
            }
            else
            {
                System.Console.WriteLine("Please enter a valid location.");
            }            
        }

        try
        {            
            Asset newAsset = new Asset
            {
                Type = type,
                Brand = brand,
                Model = model,
                Price = (decimal)price,
                PurchaseDate = purchaseDate,
                OfficeId = officeId
            };

            MyDb.Assets.Add(newAsset);
            MyDb.SaveChanges();
            Console.WriteLine($"{type} asset created successfully!");
        }       
        catch (MissingMethodException)
        {
            Console.WriteLine($"The class '{type}' does not have the expected constructor.");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine($"The asset created is not of type Asset.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }       
    }
    // public void SetLocalPrice()
    // {
    //     // Exchange rates: add more in case of more Office created
    //     double SEK = 10.3937;
    //     double EUR = 0.9148;
    //     double GBP = 0.7658;
        
    //     if(Office == "USA")
    //     {
    //         LocalPrice = Price;
    //     }
    //     else if(Office == "Germany" || Office == "Spain" )
    //     {
    //             LocalPrice = Math.Round(Price * EUR, 2);
    //     }
    //     else if(Office == "Sweden")
    //     {
    //         LocalPrice = Math.Round(Price * SEK, 2);
    //     }
    //     else if(Office == "UK")
    //     {
    //         LocalPrice = Math.Round(Price * GBP, 2);
    //     }
    //     else
    //     {
    //         Console.WriteLine($"Office '{Office}' does not have a corresponding currency.");
    //     }
    // }
}
