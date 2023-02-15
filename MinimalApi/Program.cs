using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<itemscontext>(options =>
options.UseInMemoryDatabase("itemsList"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();




app.MapGet("items/complete", async (itemscontext ic) =>
await ic.items.ToListAsync());
app.MapGet("items/{id}", async (int id, itemscontext ic) =>
await ic.items.FindAsync(id));

app.MapPost("/items", async (items i,itemscontext ic) =>
{
    ic.items.Add(i);
    await ic.SaveChangesAsync();

});

app.MapPut("/items/{id}", async (int id, items i, itemscontext ic) =>
{
    var ids = await ic.items.FindAsync(id);
    if (ids is null) return Results.NotFound();
    ids.name = i.name;
    ids.type = i.type;
    await ic.SaveChangesAsync();
    return Results.NoContent();

});
app.MapDelete("/items/{id}", async (int id, itemscontext ic) =>
{
    if (await ic.items.FindAsync(id) is items p)
    {
        ic.items.Remove(p);
        await ic.SaveChangesAsync();
        return Results.Ok(p);
    }
    return Results.NotFound();
});
app.Run();

class items
{
    public int id
    {
        get; set;
    }
    public string name { get; set; }
    public string type { get; set; }

}
class itemscontext : DbContext
{
    public itemscontext(DbContextOptions options) : base(options) 
    {
    }
    public DbSet<items> items { get; set; }
}