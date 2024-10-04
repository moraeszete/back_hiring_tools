var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços ao contêiner
builder.Services.AddControllers(); // Adicionar suporte a controladores

var app = builder.Build();

// Configurar o pipeline de requisições HTTP
app.UseHttpsRedirection(); // Redireciona HTTP para HTTPS

// Mapear os controladores
app.MapControllers(); // Mapeia automaticamente as rotas dos controladores

app.Run();
