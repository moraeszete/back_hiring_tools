var builder = WebApplication.CreateBuilder(args);

// Adicionar suporte a controladores
builder.Services.AddSingleton<MongoService>();
builder.Services.AddControllers();

// essa merda aqui tem q esta literalmente no final do arquivo
var app = builder.Build();
app.UseMiddleware<RequestLoggingMiddleware>();// Adiciona o middleware de log de requisições
app.MapControllers(); // Mapeia automaticamente as rotas dos controladores
// app.UseHttpsRedirection(); // Redireciona HTTP para HTTPS

app.Run();
