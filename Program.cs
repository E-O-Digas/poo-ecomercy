var builder = WebApplication.CreateBuilder(args);

// middlewares
builder.Services.AddControllers();

var app = builder.Build();

// app.MapGet("/", () => "AHHHHHHHHHHHHHHHHHHHHHHHhh");

app.MapControllerRoute("deafult", "/{controller}/{action}");

app.Run();
