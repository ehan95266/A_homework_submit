using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.Infrastructure.Data;
using Hrm.Infrastructure.Repository;
using Hrm.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

//dependency injection for connectionstring
builder.Services.AddDbContext<HrmDbContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("HrmApiDb"));

});

//dependency injection for repository
builder.Services.AddScoped<ICandidateRepositoryAsync, CandidateRepositoryAsync>();

//dependency injection for services
builder.Services.AddScoped<ICandidateServiceAsync, CandidateServiceAsync>();

var app = builder.Build();
app.UseRouting();//middleware allows to use routing
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.Run();


