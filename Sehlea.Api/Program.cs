using Microsoft.EntityFrameworkCore;
using Sehlea.Api.Application.DTOs.Mapping;
using Sehlea.Api.Application.UseCase;
using Sehlea.Api.Domain.Interfaces;
using Sehlea.Api.Domain.Repositories;
using Sehlea.Api.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
req => req.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultSqlServerConnection"))); //al momento de mandar a producción se debe
                                                                               //cambiar esto por una variable de ambiente

builder.Services.AddAutoMapper(conf =>
{
    conf.AddProfile<AutoMapperProfile>();
});

builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
builder.Services.AddScoped<IConsultasRepository, ConsultaRepository>();
builder.Services.AddScoped<IEstudioMedicoRepository, EstudioMedicosRepository>();
builder.Services.AddScoped<IResultadoEstudioRepository, ResultadoEstudioRepository>();

builder.Services.AddScoped<AgregarDoctor>();
builder.Services.AddScoped<MostrarDoctores>();
builder.Services.AddScoped<AgregarPaciente>();
builder.Services.AddScoped<MostrarPacientes>();
builder.Services.AddScoped<AgregarConsulta>();
builder.Services.AddScoped<BuscarConsulta>();
builder.Services.AddScoped<ObtenerProximasConsultas>();
builder.Services.AddScoped<ConsultarEstudioMedico>();
builder.Services.AddScoped<BuscarEstudioPorId>();
builder.Services.AddScoped<MostrarEstudios>();
builder.Services.AddScoped<AgregarEstudioMedico>();
builder.Services.AddScoped<AgregarResultado>();
builder.Services.AddScoped<ObtenerResultadosPorEstudio>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorDev", policy =>
    {
        policy.WithOrigins("http://localhost:5183", "https://localhost:7162")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler =
        System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//app.UseHttpsRedirection();

app.UseCors("AllowBlazorDev");

app.UseAuthorization();

app.MapControllers();

app.Run();
