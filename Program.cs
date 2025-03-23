var builder = WebApplication.CreateBuilder(args);

// middlewares
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute("deafult", "/{controller=Produto}/{action=Index}");

app.Run();
