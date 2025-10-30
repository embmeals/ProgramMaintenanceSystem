using System;
using System.Globalization;

namespace ProgramMaintenanceSystem
{
    public sealed class Software : Product
    {
        public string Version { get; set; } = string.Empty;
        public string Platform { get; set; } = string.Empty;

        public override string GetProductInfo()
        {
            var price = Price.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
            return $"Software - ID: {ProductID}, Name: '{Name}', Price: {price}, Version: '{Version}', Platform: '{Platform}'";
        }
    }
}
