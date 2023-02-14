﻿using WeatherAPI_CSharp;

var client = new APIClient("YOUR-API-KEY", true);

var weather = await client.GetWeatherCurrentAsync("Berlin");
Console.WriteLine($"The temperature in Berlin is {weather.TemperatureCelsius}C at a wind speed of {weather.WindKph}km/h");
