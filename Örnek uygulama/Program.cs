var builder = WebApplication.CreateBuilder(args);

// Gerekli servisleri ekliyoruz.
builder.Services.AddControllersWithViews(); // veya sadece AddControllers()

var app = builder.Build();

// Varsay�lan Controller rotas�n� ayarla.
app.MapDefaultControllerRoute();

app.Run();