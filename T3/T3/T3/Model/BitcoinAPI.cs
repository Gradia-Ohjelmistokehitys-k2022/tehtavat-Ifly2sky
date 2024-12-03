using System.ComponentModel;
using System.Net;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace T3.Model
{
    internal class BitcoinAPI
    {
        List<BitcoinData> _bitcoinList = new();
        public List<BitcoinData> BitcoinList { get { return _bitcoinList; } set { _bitcoinList = value; } }
        public BitcoinAPI() 
        {
            
        }
        private static DateTime GetDateTimeFromBicoinsDB(BitcoinResponse bitcoins, int row)
        {
            var e = (JsonElement)bitcoins.prices[row][0];
            long time;
            e.TryGetInt64(out time);
            return DateTimeOffset.FromUnixTimeMilliseconds(time).DateTime;
        }

        private static decimal GetPriceFromBitcoinsDB(BitcoinResponse bitcoins, int row)
        {
            var e = (JsonElement)bitcoins.prices[row][1];
            decimal price;
            e.TryGetDecimal(out price);
            return price;
        }

        private static decimal GetMarketCapFromBitcoinsDB(BitcoinResponse bitcoins, int row)
        {
            return (decimal)bitcoins.market_caps[row][1];
        }
        
        private static double GetTotalVolumeFromBitcoinsDB(BitcoinResponse bitcoins, int row)
        {
            return bitcoins.total_volumes[row][1];
        }
        public  List<BitcoinData> GetBitcoins(DateTime start, DateTime end)
        {
            string startDate = (new DateTimeOffset(start)).ToUnixTimeSeconds().ToString();
            string endDate = (new DateTimeOffset(end)).ToUnixTimeSeconds().ToString();
            BitcoinResponse bitcoins = GetBitcoinsInRange(startDate, endDate);

            if (bitcoins.prices is not null && bitcoins.prices.Length > 0)
            {
                for (int i = 0; i < bitcoins.prices.GetLength(0); i++)
                {
                    BitcoinData bitcoin = new()
                    {
                        DateTime = GetDateTimeFromBicoinsDB(bitcoins, i),
                        Price = GetPriceFromBitcoinsDB(bitcoins, i),
                        Market_cap = GetMarketCapFromBitcoinsDB(bitcoins, i),
                        Total_volume = GetTotalVolumeFromBitcoinsDB(bitcoins, i)
                    };

                    _bitcoinList.Add(bitcoin);
                }
                return BitcoinList;
            }

            return null;
        }
        public static BitcoinResponse GetBitcoinsInRange(string startDate, string endDate)
        {
            string url = $"https://api.coingecko.com/api/v3/coins/bitcoin/market_chart/range?vs_currency=eur&from={startDate}&to={endDate}";     // the url is created including user's input from the form
            BitcoinResponse bitcoinResponse = new();

            try
            {
                HttpClient client = new HttpClient();
                Task<HttpResponseMessage> response = client.GetAsync(url);
                response.Wait();
                HttpResponseMessage responseMessage = response.Result;

                string bitcoins;
                using (System.IO.StreamReader JsonResponseReader = new(responseMessage.Content.ReadAsStream()))
                {
                    bitcoins = JsonResponseReader.ReadToEnd();
                }
                bitcoinResponse = JsonSerializer.Deserialize<BitcoinResponse>(bitcoins);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

            return bitcoinResponse;
        }
    }
}
