using System;
using System.Globalization;

namespace ProgramMaintenanceSystem
{
    public abstract class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public abstract string GetProductInfo();
    }
}