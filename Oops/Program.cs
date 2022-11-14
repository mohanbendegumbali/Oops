
using Oops.InventoryManagement;
using System; 

namespace Demo 
{
    class Program 
    {
        static string inventoryFilePath = @"C:\Users\mohan\OneDrive\Documents\GitRepository\Oops\Oops\InventoryManagement\Inventory.json";
        public static void Main(string[] args) 
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Management");
                Console.WriteLine(" Enter the Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
                        inventoryDetailsManagement.ReadJsonFile(inventoryFilePath);
                        break;

                }
            }
        }
    }
}

