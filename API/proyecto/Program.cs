using projectoef;
using projectoef.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<TareasContext>("Data Source=server;Initial Catalog=TareasDb;user id=sa;password=pass");
//añadir dependencias
builder.Services.AddScoped<IHelloWorldService, HelloWorldService>(); //forma#1
//builder.Services.AddScoped(p=> new HelloWorldService()); //forma#2
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<ITareasService, TareasService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseWelcomePage();

//app.UseTimeMiddleware();

app.MapControllers();

app.Run();