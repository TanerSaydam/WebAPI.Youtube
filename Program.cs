using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//service registration
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen().AddEndpointsApiExplorer();

builder.Services.AddCors();

var app = builder.Build();
//middleware
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();

app.MapOpenApi();
app.MapScalarApiReference();
//}

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.MapControllers();

app.Run();
