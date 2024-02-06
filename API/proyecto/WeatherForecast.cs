namespace webapi;

public class WeatherForecast
{

    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
    public WeatherForecast(DateTime ddd, int TemperatureC, string Summary)
    {
        Date = (DateTime)ddd;
        this.TemperatureC = TemperatureC;
        this.Summary = Summary;
    }


}