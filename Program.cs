using RockPaperScissorsLizardSpock.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//added my builder for the service to be in scope
builder.Services.AddScoped<RockPaperScissorsLizardSpockService>();

//adding Cors policy
builder.Services.AddCors(Options => {
    Options.AddPolicy("AllowAll", 
    policy =>
    {
        //allows access from any origin
        //allows any http request a.k.a httpget, httppost, httpput et cetera
        //Allows any header
        policy.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
