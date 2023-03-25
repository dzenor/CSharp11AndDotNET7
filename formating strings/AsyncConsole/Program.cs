HttpClient client = new();

HttpResponseMessage response = 
    await client.GetAsync("http://www.apple.com/");

Console.WriteLine("Apples home has {0:N0} bytes",response.Content.Headers);
