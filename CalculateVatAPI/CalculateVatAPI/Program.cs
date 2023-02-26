using CalculateVatAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DI - Registering services
builder.Services.AddScoped<IVatService, VatService>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddCors(options => options.AddPolicy(name: "CalculateVat", 
    policy =>
    {
        policy.AllowAnyOrigin();
        policy.WithMethods("GET", "PUT",
    "POST", "DELETE") //AllowSpecificMethods;
                      //.AllowAnyMethod() //AllowAllMethods;

    //.WithHeaders("Accept", "Content-type", "Origin", "X-Custom-Header");  
    //AllowSpecificHeaders;
    .AllowAnyHeader(); //AllowAllHeaders;
    }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CalculateVat");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
