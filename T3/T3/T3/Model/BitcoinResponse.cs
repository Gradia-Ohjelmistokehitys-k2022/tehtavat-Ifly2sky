namespace T3.Model
{
    /// <summary>
    /// Reprecents the Json response of the API
    /// </summary>
    public class BitcoinResponse
    {
        public object[][] prices { get; set; }
        public double[][] market_caps { get; set; }
        public double[][] total_volumes { get; set; }
    }
}
