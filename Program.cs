using CoffeCodeDevops.Data;
using CoffeCodeDevops.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DBDataContext>();
builder.Services.AddScoped(typeof(TestTableRepository));
builder.Services.AddScoped(typeof(FeedbackRepository));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("*");
        });
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors(x => x
      .AllowAnyMethod()
      .AllowAnyOrigin()
      .AllowAnyHeader()
      .SetIsOriginAllowed(origin => true));


using (var context = new DBDataContext())
{
    Console.WriteLine("Executando Migrations...");
    context.Database.Migrate();
    Console.WriteLine("OK...");
}
app.Run();
