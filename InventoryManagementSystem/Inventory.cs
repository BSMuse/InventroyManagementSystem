using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public static Part lookupPart(int partID)
        {
            var part = AllParts.FirstOrDefault(p => p.PartID == partID);
            if (part == null)
            {
                throw new KeyNotFoundException($"Part with ID {partID} not found.");
            }
            return part;
        }

      public static Product lookupProduct(int productID)
        {
            var product = Products.FirstOrDefault(p => p.ProductID == productID);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with ID {productID} not found.");
            }
            return product;
        }

        public static void addPart(Part part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }
            AllParts.Add(part);
        }

        public static void addProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            Products.Add(product);
        }

        public static bool removePart(int partID)
        {
            var part = lookupPart(partID);
            if (part == null)
            {
                return false;
            }
            AllParts.Remove(part);
            return true;
        }

        public static bool removeProduct(int productId)
        {
            var product = lookupProduct(productId);
            if (product == null)
            {
                return false;
            }
            Products.Remove(product);
            return true;
        }

        public static void updateProduct(int productID, Product updatedProduct)
        {
            var existingProduct = lookupProduct(productID);
            if (existingProduct != null && updatedProduct != null)
            {
                int index = Products.IndexOf(existingProduct);
                Products[index] = updatedProduct; 
            }
        }

        public static void updatePart(int partID, Part updatedPart)
        {
            var existingPart = lookupPart(partID);
            if (existingPart != null && updatedPart != null)
            {
                int index = AllParts.IndexOf(existingPart);
                AllParts[index] = updatedPart;
            }
        }
    }
}
