using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Oops.InventoryManagement
{
    public class InventoryDetailsManagement
    {
        public void ReadJsonFile(string file)
        {
            var jsonData = File.ReadAllText(file);
            List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(jsonData);
            foreach(var data in inventories)
            {
                Console.WriteLine(data.Name +"\n" +data.Price +"\n" +data.Weight);
            }
        }
    }
}
