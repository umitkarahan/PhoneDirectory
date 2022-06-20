using Contact.ServicePersistance;
using ContactService.Application.Interactions.Contacts;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContactServiceDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContactServiceDBContext"));
});

builder.Services.AddMediatR(typeof(GetAllContacts).Assembly);


var app = builder.Build();

var scope = app.Services.CreateScope();
scope.ServiceProvider.GetService<ContactServiceDBContext>()?.Database.Migrate();
;

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
