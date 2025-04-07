using Coding_Challenge_dotnetapi.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<_DBEntities>(options =>
{
    options.UseInMemoryDatabase("voxdb");
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

dbSetup();

app.Run();




void dbSetup()
{
    using var scope = app.Services.CreateScope();
    using _DBEntities dbContext = scope.ServiceProvider.GetRequiredService<_DBEntities>();

    List<Character> characters = new List<Character>()
    {
        new Character()
        {
            Name = "Pike",
            Stat = new Stat() {StatId = 1, Name = "Health", Value = 5},
            Traits = new List<Trait>
            {
                new Trait()
                {
                    Name = "Healthy",
                    ModifierValue = 0
                }
            }
        },
        new Character()
        {
            Name = "Vax",
            Traits = new List<Trait>
            {
                new Trait()
                {
                    Name = "Wounded",
                    ModifierValue = -2
                }
            }
        }
    };

    dbContext.Characters.AddRange(characters);
    dbContext.SaveChanges();


}