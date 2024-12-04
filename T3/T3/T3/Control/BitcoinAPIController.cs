using System;
using T3.Model;

namespace T3.Control
{
    public static class BitcoinAPIController
    {
        private static BitcoinAPI api = new BitcoinAPI();
        static DateTime BestBuy;
        static DateTime BestSell;
        public static bool FetchData(DateTime start, DateTime end)
        {
            if (api.GetBitcoins(start, end) is null)
            {
                return false;
            }
            return true;
        }
        public static BitcoinData GetLargestVolume()
        {
            BitcoinData largest = new BitcoinData();
            largest.Total_volume = 0;
            foreach (BitcoinData bitcoin in api.BitcoinList)
            {
                if (bitcoin.Total_volume > largest.Total_volume)
                    largest = bitcoin;
            }
            return largest;
        }
        public static BitcoinData GetSmallestVolume()
        {
            BitcoinData smallest = new();
            smallest.Total_volume = api.BitcoinList[0].Total_volume;
            foreach (BitcoinData bitcoin in api.BitcoinList)
            {
                if (bitcoin.Total_volume < smallest.Total_volume)
                    smallest = bitcoin;
            }
            return smallest;
        }
        public static int[] GetHighestTrends()
        {
            int upwards = 0;
            int downwards = 0;
            int trend = 0;
            BitcoinData last = api.BitcoinList[0];

            foreach (BitcoinData data in api.BitcoinList)
            {
                if (data.DateTime.Date== last.DateTime.Date)
                    continue;
                if (data.Total_volume > last.Total_volume)
                {
                    if (trend >= 0)
                        trend++;
                    else
                    {
                        if (trend < downwards)
                        {
                            downwards = trend;
                            BestBuy = last.DateTime;
                        }
                        trend = 1;
                    }
                }
                else if (data.Total_volume < last.Total_volume)
                {
                    if (trend <= 0)
                        trend--;
                    else
                    {
                        if (trend > upwards)
                        {
                            upwards = trend;
                            BestSell = data.DateTime;
                        }
                        trend = -1;
                    }
                }
                else
                {
                    if (trend < 0)
                        trend--;
                    if (trend > 0)
                        trend++;
                }
                last = data;
            }

            return new int[2] {-downwards, upwards};
        }
        public static DateTime GetBestBuyTime()
        {

            return BestBuy;
        }
        public static DateTime GetBestSellTime()
        {

            return BestSell;
        }
    }
}
