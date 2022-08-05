using Antra.CustomerCRM.Core.Contracts.Repository;
using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Entities;
using Antra.CustomerCRM.Infrastructure.Data;
using Antra.CustomerCRM.Infrastructure.Repository;
using Antra.CustomerCRM.Infrastructure.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ICategoryRepositoryAsync, CategoryRepositoryAsync>();
builder.Services.AddScoped<ICategoryServiceAsync, CategoryServiceAsync>();

builder.Services.AddScoped<ICustomerRepositoryAsync, CustomerRepositoryAsync>();
builder.Services.AddScoped<ICustomerServiceAsync, CustomerServiceAsync>();

builder.Services.AddScoped<IEmployeeRepositoryAsync, EmployeeRepositoryAsync>();
builder.Services.AddScoped<IEmployeeServiceAsync, EmployeeServiceAsync>();

builder.Services.AddScoped<IProductRepositoryAsync, ProductRepositoryAsync>();
builder.Services.AddScoped<IProductServiceAsync, ProductServiceAsync>();

builder.Services.AddScoped<IRegionRepositoryAsync, RegionRepositoryAsync>();
builder.Services.AddScoped<IRegionServiceAsync, RegionServiceAsync>();

builder.Services.AddScoped<IShipperRepositoryAsync, ShipperRepositoryAsync>();
builder.Services.AddScoped<IShipperServiceAsync, ShipperServiceAsync>();

builder.Services.AddScoped<IVendorRepositoryAsync, VendorRepositoryAsync>();
builder.Services.AddScoped<IVendorServiceAsync, VendorServiceAsync>();

builder.Services
    .AddSqlServer<CustomerCrmDbContext>(
    builder.Configuration.GetConnectionString("CustomerCRM")
    );
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<CustomerCrmDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});

var app = builder.Build();

// anything that uses app is a middleware

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
