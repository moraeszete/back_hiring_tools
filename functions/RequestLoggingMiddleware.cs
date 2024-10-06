using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Log da rota chamada
        Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

        // Chama o próximo middleware na cadeia
        await _next(context);
    }
}
