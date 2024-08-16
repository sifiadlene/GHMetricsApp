using Microsoft.AspNetCore.Components;

using System.Net.Http.Json;
namespace GHMetricsApp.Pages
{
    public partial class Weather : ComponentBase
    {
        public WeatherForecast[] Forecasts { get; private set; } = Array.Empty<WeatherForecast>();
        protected override async Task OnInitializedAsync()
        {
            var data = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            if (data != null)
            {
                Forecasts = data;
            }
        }
        protected override void OnInitialized()
        {
            // Initialization logic here
        }

        private void FetchWeatherData()
        {
            // Fetch weather data logic here
        }

        private void DisplayWeatherData()
        {
            // Display weather data logic here
        }
    }

    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}