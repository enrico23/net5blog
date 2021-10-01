namespace Blog.Web.Rest.Representations
{
    public class LocalizedWeatherForecast : WeatherForecast
    {
        public string Title { get; set; }
        public string Name { get; set; }
    }
}