using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task2
{
    public static class CurrencyConverter
    {
        private readonly static string jsonFilePath = @"C:\Users\NinoGachechiladze\Desktop\ITAcademyCSHarp\Homeworks\HomeWork8\Task2\CurrencyRates.json";
        public static Decimal ConvertedCurrencyAmount(Currency fromAccount, Currency toAccount,decimal Amount)
        {
            var from = GetRateByName(fromAccount.CurrencyLabel);
            var to  = GetRateByName(toAccount.CurrencyLabel);

            return (Amount * from.Rate) / to.Rate;
        }

        private static  Rates[] GetRates() {
            string jsonContent = File.ReadAllText(jsonFilePath);
            return JsonSerializer.Deserialize<Rates[]>(jsonContent);            
        }

        private static Rates GetRateByName(ECurrency name)
        {

            return GetRates().FirstOrDefault(rate => rate.CurrencyCode == name.ToString());
        }
    }
}
