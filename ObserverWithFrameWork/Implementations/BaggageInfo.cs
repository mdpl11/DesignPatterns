namespace Observer.Implementations
{
    public class BaggageInfo
    {
        private readonly int flightNo;
        private readonly string origin;
        private readonly int location;

        internal BaggageInfo(int flight, string from, int carousel)
        {
            this.flightNo = flight;
            this.origin = from;
            this.location = carousel;
        }

        public int FlightNumber
        {
            get { return flightNo; }
        }

        public string From
        {
            get { return origin; }
        }

        public int Carousel
        {
            get { return location; }
        }
    }
}