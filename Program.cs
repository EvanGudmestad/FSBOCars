var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// Register HttpClient for dependency injection
builder.Services.AddHttpClient();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
