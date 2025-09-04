using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenApiAutomation
{
    class Program
    {
        // Choose a model you have access to. gpt-4o-mini is fast/cost-effective.
        private const string Model = "gpt-4o-mini";

        static async Task<int> Main(string[] args)
        {
            var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                Console.Error.WriteLine("ERROR: OPENAI_API_KEY environment variable is not set.");
                return 1;
            }

            Console.WriteLine("ChatGPT console. Type your message and press Enter. Empty line to exit.");
            using var http = new HttpClient
            {
                BaseAddress = new Uri("https://api.openai.com/")
            };
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            while (true)
            {
                Console.Write("\nYou: ");
                var userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                    break;

                try
                {
                    var request = new ChatCompletionsRequest
                    {
                        Model = Model,
                        Messages = new[]
                        {
                            new ChatMessage { Role = "system", Content = "You are a helpful assistant." },
                            new ChatMessage { Role = "user", Content = userInput }
                        },
                        Temperature = 0.7
                    };

                    var json = JsonSerializer.Serialize(request, JsonOptions);
                    using var content = new StringContent(json, Encoding.UTF8, "application/json");

                    using var response = await http.PostAsync("v1/chat/completions", content);
                    var body = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"[HTTP {((int)response.StatusCode)}] {response.ReasonPhrase}");
                        Console.WriteLine(body);
                        Console.ResetColor();
                        continue;
                    }

                    var completion = JsonSerializer.Deserialize<ChatCompletionsResponse>(body, JsonOptions);
                    var text = completion?.Choices?[0]?.Message?.Content?.Trim();

                    if (string.IsNullOrWhiteSpace(text))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("No content returned.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Assistant: {text}");
                        Console.ResetColor();
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Request failed:");
                    Console.WriteLine(ex);
                    Console.ResetColor();
                }
            }

            return 0;
        }

        // ----- Models & JSON options -----

        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        private sealed class ChatCompletionsRequest
        {
            [JsonPropertyName("model")]
            public string Model { get; set; } = default!;

            [JsonPropertyName("messages")]
            public ChatMessage[] Messages { get; set; } = default!;

            [JsonPropertyName("temperature")]
            public double? Temperature { get; set; }
        }

        private sealed class ChatMessage
        {
            [JsonPropertyName("role")]
            public string Role { get; set; } = default!; // "system" | "user" | "assistant"

            [JsonPropertyName("content")]
            public string Content { get; set; } = default!;
        }

        private sealed class ChatCompletionsResponse
        {
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            [JsonPropertyName("choices")]
            public Choice[]? Choices { get; set; }
        }

        private sealed class Choice
        {
            [JsonPropertyName("index")]
            public int Index { get; set; }

            [JsonPropertyName("message")]
            public AssistantMessage? Message { get; set; }
        }

        private sealed class AssistantMessage
        {
            [JsonPropertyName("role")]
            public string? Role { get; set; }

            [JsonPropertyName("content")]
            public string? Content { get; set; }
        }
    }
}
