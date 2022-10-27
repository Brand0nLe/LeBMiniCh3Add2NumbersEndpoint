//Brandon Le
//10-25-22
//Mini Challenge 3 - Add 2 numbers
//Web API project that will take the users two inputs in the url and add the two numbers together.
//The sum will show up for the user when running MiniCh3/Adding/number1/number2.
//For example if it's MiniCh3/Adding/3/5 the outcome would be 8.
//Peer Review: Ulises Ortega - The endpoint works as intended it takes the two numbers and output the addition of the 2 numbers.



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
