using Microsoft.EntityFrameworkCore;
using RealEstate1.Data;
using RealEstate1.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");

//DbContext configuration
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

//Service configuration
builder.Services.AddScoped<IEstatesService, EstatesService>();

var app = builder.Build();

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
    pattern: "{controller=Estates}/{action=Index}/{id?}");

AppDbInitializer.Seed(app);

app.Run();
