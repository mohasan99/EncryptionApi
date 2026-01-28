var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simple encryption by reversing the string
app.MapGet("/encrypt", (string text) => 
    Results.Ok(new { original = text, result = new string(text.Reverse().ToArray()) }));

// Simple decryption by reversing the string back
app.MapGet("/decrypt", (string text) => 
    Results.Ok(new { original = text, result = new string(text.Reverse().ToArray()) }));

app.Run();