namespace Halcyon.WLED
{
    /// <summary>
    /// Settings class, make sure it can be correctly serialized using JSON.net
    /// </summary>
    public class WLEDSettings
    {
        public string stripUrl { get; set; } = "wled-table.local";
        public int stripPort { get; set; } = 21324;

        public int ledAmount { get; set; } = 60;
        public int offset { get; set; } = 0;

        public bool mirror { get; set; } = false;
        public bool center { get; set; } = false;
    }
}