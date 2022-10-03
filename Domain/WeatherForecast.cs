namespace Domain;

public class WeatherForecast
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public Boolean WillAttend => Random.Shared.Next(2) == 1;

    public string? Summary { get; set; }
}
