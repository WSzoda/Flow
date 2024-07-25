namespace Flow.Application.Exceptions
{
    class GeolocalizationNotFoundException : Exception
    {
        public GeolocalizationNotFoundException( ){}

        public GeolocalizationNotFoundException(string message) : base(message){}
    }
}