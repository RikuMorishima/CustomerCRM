using Antra.CustomerCRM.Core.Contracts.Repository;
using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Infrastructure.Data;
using Antra.CustomerCRM.Infrastructure.Repository;
using Antra.CustomerCRM.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddScoped<IRegionRepositoryAsync, RegionRepositoryAsync>();
builder.Services.AddScoped<IRegionServiceAsync, RegionServiceAsync>();


builder.Services
    .AddSqlServer<CustomerCrmDbContext>(
    builder.Configuration.GetConnectionString("CustomerCRM")
    );

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
