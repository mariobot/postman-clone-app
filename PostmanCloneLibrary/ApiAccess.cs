﻿using System.Text;
using System.Text.Json;

namespace PostmanCloneLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient client = new();
    public async Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool formatOutput = true)
    {
        HttpContent stringContent = new StringContent(content, Encoding.UTF8, "application/json");
        return await CallApiAsync(url, stringContent, action, formatOutput);
    }

    public async Task<string> CallApiAsync(string url, HttpContent? content = null, HttpAction action = HttpAction.GET, bool formatOutput = true)
    {
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();

            if (formatOutput)
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }

            return json;
        }
        else
        {
            return $"Error: " + response.StatusCode;
        }
    }

    public bool IsValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }

        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri? uriOutput) && (uriOutput?.Scheme == Uri.UriSchemeHttps);

        return output;
    }
}
