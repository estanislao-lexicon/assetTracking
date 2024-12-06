using System.Globalization;
using MyDbContextNamespace;
using AssetNameSpace;


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
            System.Console.WriteLine("\nChoose your Option: (C)reate new Asset, (D)elete Asset, (U)pdate Asset, (P)rint list, (R)eport, or (Q)uit.");
            System.Console.Write(">");
            string input = Console.ReadLine().ToUpper();

            if(input == "C")
            {
                NewAsset(MyDb);
            }
            else if(input == "D")
            {
                DeleteAsset(MyDb);
            }
            else if(input == "U")
            {
                UpdateAsset(MyDb);
            }
            else if(input == "P")
            {
                PrintList(MyDb);
            }
            else if(input == "R")
            {
                Report(MyDb);
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
        string headers = "ID".PadRight(5) + "Asset".PadRight(20) + "Brand".PadRight(20) + "Model".PadRight(20) + "Local Price".PadRight(20) + "Purchase Date".PadRight(20) + "Office".PadRight(20) + "\n";
        System.Console.WriteLine(headers);
        string divider = new string('-', headers.Length);
        System.Console.WriteLine(divider);
        Console.ResetColor();

        // Sort Assets by Office then Purchase date & add Office name
        var assetsWithOfficeNames = MyDb.Assets
            .Join(MyDb.Offices, // Join the Assets table with the Offices table
                asset => asset.OfficeId,
                office => office.Id, 
                (asset, office) => new
                {
                    asset.Id,
                    asset.Type,
                    asset.Brand,
                    asset.Model,
                    asset.Price,
                    asset.PurchaseDate,                    
                    OfficeName = office.Name,                    
                    Currency = office.LocalCurrency 
                })
            .OrderBy(a => a.OfficeName) 
            .ThenBy(a => a.PurchaseDate); 

        foreach(var asset in assetsWithOfficeNames)        
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
            
            double localPrice = ConvertToLocalPrice(asset.Price, asset.Currency);

            System.Console.WriteLine($"{asset.Id}".PadRight(5) + $"{asset.Type}".PadRight(20) + $"{asset.Brand}".PadRight(20) + $"{asset.Model}".PadRight(20) + $"{localPrice} {asset.Currency}".PadRight(20) + $"{asset.PurchaseDate.ToString("dd-MM-yyyy")}".PadRight(20) + $"{asset.OfficeName}".PadRight(20));            
        }
    }

    public static void NewAsset(MyDbContext MyDb)
    {            
        string type;
        while (true)
        {
            System.Console.WriteLine("Please enter the type of asset you want to create (Computer, Smartphone, etc):");
            System.Console.Write(">");
            type = Console.ReadLine();
                        
            if (!string.IsNullOrEmpty(type))
            {
                type = char.ToUpper(type[0]) + type.Substring(1).ToLower();
            }            
                       
            if (type != null)
            {
                break;
            }

            System.Console.WriteLine($"Asset type '{type}' is not recognized. Please ensure it is a valid class name.");
        }

        System.Console.WriteLine($"Please enter the brand of the {type}:");
        System.Console.Write(">");
        string brand = Console.ReadLine();

        System.Console.WriteLine($"Please enter the model of the {type}:");
        System.Console.Write(">");
        string model = Console.ReadLine();

        double price;    
        System.Console.WriteLine($"Please enter the price in USD of the {type}:");
        System.Console.Write(">");
        string input = Console.ReadLine();

        while (!double.TryParse(input, out price) || price <= 0)
        {
            System.Console.WriteLine("Invalid price. Please enter a numeric value greater than 0:");
            System.Console.Write(">");
            input = Console.ReadLine();
        }

        System.Console.WriteLine($"Please enter the purchase date (yyyy-mm-dd) of the {type}:");
        System.Console.Write(">");
        string purchaseDateString = Console.ReadLine();
        DateTime purchaseDate;

        if (!DateTime.TryParseExact(purchaseDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out purchaseDate))
        {
            System.Console.WriteLine("Invalid purchase date format. Asset creation aborted.");
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
                Price = price,
                PurchaseDate = purchaseDate,
                OfficeId = officeId
            };

            MyDb.Assets.Add(newAsset);
            MyDb.SaveChanges();
            System.Console.WriteLine($"{type} asset created successfully!");
        }       
        catch (MissingMethodException)
        {
            System.Console.WriteLine($"The class '{type}' does not have the expected constructor.");
        }
        catch (InvalidCastException)
        {
            System.Console.WriteLine($"The asset created is not of type Asset.");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }       
    }
    public static void DeleteAsset(MyDbContext MyDb)
    {
        int id;        
        while(true)
        {
            System.Console.WriteLine("Please enter the asset's ID you want to delete");
            System.Console.Write(">");
            string input = Console.ReadLine();
            try
            {
                id = Int32.Parse(input);
                break;
            }
            catch (FormatException)
            {
                System.Console.WriteLine($"Please enter a valid number");
            }
        }
            
        string assetName = MyDb.Assets
            .Where(a => a.Id == id)
            .Select(a => a.Brand + " " + a.Model)
            .FirstOrDefault();

        var assetToDelete = MyDb.Assets.FirstOrDefault(a => a.Id == id);
        if(assetToDelete != null)
        {        
            MyDb.Assets.Remove(assetToDelete);
            MyDb.SaveChanges();
            System.Console.WriteLine($"Asset {assetName} has been deleted");
        }
        else
        {
            System.Console.WriteLine($"No asset found with ID {id}. Deletion aborted");
        }
    }

    public static void UpdateAsset(MyDbContext MyDb)
    {
        int id;        
        string input;

        while(true)
        {
            Console.WriteLine("Please enter the asset's ID you want to update");
            Console.Write(">");
            input = Console.ReadLine();
            try
            {
                id = Int32.Parse(input);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Please enter a valid number");
            }
        }

        // Retrieve the asset from the db
        var asset = MyDb.Assets.FirstOrDefault(a => a.Id == id);

        if(asset == null)
        {
            System.Console.WriteLine("Asset not found");
            return;
        }

        // Display selected asset and update menu
        Console.Clear();        
        System.Console.WriteLine("You selected:");
        System.Console.WriteLine($"ID: {asset.Id}, Brand: {asset.Brand}, Model: {asset.Model}, Price: {asset.Price}, Purchase Date: {asset.PurchaseDate:yyyy-MM-dd}");
        System.Console.WriteLine(" ");

         while (true)
        {
            Console.WriteLine("Select what you want to update:");
            Console.WriteLine("1. Brand");
            Console.WriteLine("2. Model");
            Console.WriteLine("3. Price");
            Console.WriteLine("4. Purchase Date");
            Console.WriteLine("5. Return");
            Console.Write(">");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter the new Brand: ");
                    asset.Brand = Console.ReadLine();
                    break;

                case "2":
                    Console.Write("Enter the new Model: ");
                    asset.Model = Console.ReadLine();
                    break;

                case "3":
                    Console.Write("Enter the new Price (in USD): ");
                    if (double.TryParse(Console.ReadLine(), out double newPrice) && newPrice > 0)
                    {
                        asset.Price = newPrice;
                    }
                    else
                    {
                        Console.WriteLine("Invalid price. Please try again.");
                    }
                    break;

                case "4":
                    Console.Write("Enter the new Purchase Date (yyyy-MM-dd): ");
                    if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime newDate))
                    {
                        asset.PurchaseDate = newDate;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Please try again.");
                    }
                    break;

                case "5":
                    Console.WriteLine("Returning to the main menu...");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please select a valid choice.");
                    break;
            }

            // Save changes to the database
            try
            {
                MyDb.SaveChanges();
                Console.WriteLine("Asset updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating asset: {ex.Message}");
            }

            // Display updated asset
            Console.WriteLine($"Updated Asset: ID: {asset.Id}, Brand: {asset.Brand}, Model: {asset.Model}, Price: {asset.Price}, Purchase Date: {asset.PurchaseDate:yyyy-MM-dd}");
            Console.WriteLine();
        }
    }

    public static void Report(MyDbContext MyDb)
    {        
        var report = MyDb.Assets
            .GroupBy(a => new { a.Type, a.OfficeId })
            .Select(g => new
            {
                Type = g.Key.Type,
                OfficeId = g.Key.OfficeId,
                Count = g.Count()
            })
            .ToList();

        foreach (var office in MyDb.Offices)
        {
            Console.WriteLine($"{office.Name}:");
            foreach (var asset in report.Where(r => r.OfficeId == office.Id))
            {
                Console.WriteLine($"  {asset.Type}: {asset.Count}");
            }
        }

    }

    public static double ConvertToLocalPrice(double price, string currency)
    {
        var exchangeRates = new Dictionary<string, double>
        {
            { "usd", 1.0 },
            { "sek", 10.3937 },
            { "eur", 0.9148 }
        };

        return exchangeRates.TryGetValue(currency.ToLower(), out double rate)
            ? Math.Round(price * rate, 2)
            : 0;
    }
}
