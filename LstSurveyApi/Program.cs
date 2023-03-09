using LstSurveyApi.Context;
using LstSurveyApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<OptionContext>(ServiceLifetime.Scoped);
        builder.Services.AddDbContext<SurveyContext>(ServiceLifetime.Scoped);
        builder.Services.AddDbContext<QuestionContext>(ServiceLifetime.Scoped); 
        builder.Services.AddDbContext<UserContext>(ServiceLifetime.Scoped);
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAllOrigins",
           builder =>
           {
               builder.AllowAnyOrigin()
                      .AllowAnyHeader()
                      .AllowAnyMethod();
           });
        });
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
     .AddJwtBearer(options =>
     {
         options.TokenValidationParameters = new TokenValidationParameters
         {
             ValidateIssuer = true,
             ValidateAudience = true,
             ValidateLifetime = true,
             ValidateIssuerSigningKey = true,
             ValidIssuer = "your-issuer",
             ValidAudience = "your-audience",
             IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your-secret-key"))
         };
     });
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseCors("AllowAllOrigins");

        app.UseAuthentication();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}