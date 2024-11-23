using Backend1.Services;

var builder = WebApplication.CreateBuilder(args);

// Регистрация сервиса
// В Program.cs для ASP.NET Core 6+
builder.Services.AddTransient<IOperationService, OperationService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllers(); // Для работы с контроллерами

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "calculate",
    pattern: "Math/Calculate",
    defaults: new { controller = "Math", action = "Index" });

app.Run();