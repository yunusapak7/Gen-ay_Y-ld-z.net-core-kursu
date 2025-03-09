var builder = WebApplication.CreateBuilder(args);

// Gerekli servisleri ekliyoruz.
builder.Services.AddControllersWithViews(); // veya sadece AddControllers()

var app = builder.Build();

// Varsayýlan Controller rotasýný ayarla.
app.MapDefaultControllerRoute();

app.Run();