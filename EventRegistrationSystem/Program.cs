using EventRegistrationSystem.Data;
using EventRegistrationSystem.Services.IServices;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddControllersWithViews();
//builder.Services.AddMvc(options =>
//{
//    options.Filters.Add(new ValidateAntiForgeryTokenAttribute());
//});

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen(options => {
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = " Authorization Header using Bearer (bearer {token})",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String(builder.Configuration.GetSection("AppSettings:SecretKey").Value)),
            ValidateIssuer = false,
            ValidateAudience = false,
        };
    });

//builder.Services.AddAntiforgery(options =>
//{
//    // Set Cookie properties using CookieBuilder properties†.\
//    options.HeaderName = "X-XSRF-TOKEN";
//    options.SuppressXFrameOptionsHeader = false;
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseCors(x => x.AllowAnyHeader()
//      .AllowAnyMethod()
//      .AllowCredentials()
//      .WithOrigins(""));

app.UseAuthentication();

app.UseAuthorization();

//var antiforgery = app.Services.GetRequiredService<IAntiforgery>();

//app.Use((context, next) =>
//{
//    var requestPath = context.Request.Path.Value;

//    if (string.Equals(requestPath, "/", StringComparison.OrdinalIgnoreCase)
//        || string.Equals(requestPath, "/index.html", StringComparison.OrdinalIgnoreCase))
//    {
//        var tokenSet = antiforgery.GetAndStoreTokens(context);
//        context.Response.Cookies.Append("X-XSRF-TOKEN", tokenSet.RequestToken!, new CookieOptions { HttpOnly = false, Secure = true });
//    }

//    return next(context);
//});

app.MapControllers();

app.Run();
