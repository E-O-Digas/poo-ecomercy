var builder = WebApplication.CreateBuilder(args);

// middlewares
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllerRoute("deafult", "/{controller}/{action}");

app.Run();
