var builder = WebApplication.CreateBuilder(args);

// Configura builder con AddControllersWithViews()
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Configura app con MapDefaultControllerRoute()
app.MapDefaultControllerRoute();

// Configura app con Run()
app.Run();
