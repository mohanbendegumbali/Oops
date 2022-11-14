using Newtonsoft.Json;
using Oops.InventoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.InventoryDataManagement
{
    public class InventoryDataManagementList
    {
        List<Inventory> RiceList;
        List<Inventory> WheatList;
        List<Inventory> PulsesList;
        public void ReadJsonFile(string file)
        {
            var jsonData = File.ReadAllText(file);
            InventoryData inventories = JsonConvert.DeserializeObject<InventoryData>(jsonData);
            List<InventoryData> RiceList = inventories.Rice;
            Display(RiceList);
            List<InventoryData> WheatList = inventories.Wheat;
            Display(WheatList);
            List<InventoryData> PulsesList = inventories.Pulses;
            Display(PulsesList);

        }

        public void Display(List<InventoryData> riceList)
        {
            foreach(var data in inventories)
            {
                Console.WriteLine(data.Name + "\n" +data.Price + "\n" +data.Weight);
            }
        }
    }
}
