using System;
using System.Globalization;

namespace ProgramMaintenanceSystem
{
    public class Book : Product
    {
        public string Author { get; set; } = string.Empty;

        public override string GetProductInfo()
        {
            var price = Price.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
            return $"Book - ID: {ProductID}, Name: '{Name}', Price: {price}, Author: {Author}";
        }
    }
}