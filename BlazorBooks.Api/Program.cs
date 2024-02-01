using BlazorBooks.Api.Data;
using BlazorBooks.Api.Repositories;
using BlazorBooks.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<BlazorBooksDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlazorBooksConnection"))
);

builder.Services.AddScoped<IBookRepository,BookRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
