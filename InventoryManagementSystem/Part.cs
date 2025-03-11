using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public bool IsInHouse { get; set; }
        public int MachineID { get; set; }
        public string CompanyName { get; set; }

        public Part(int partID, string name, decimal price, int inStock, int min, int max, bool isInHouse, int machineID, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            IsInHouse = isInHouse;
            MachineID = machineID;
            CompanyName = companyName;
        }

    }
}
