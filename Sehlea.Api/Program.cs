using Microsoft.EntityFrameworkCore;
using Sehlea.Api.Application.DTOs.Mapping;
using Sehlea.Api.Application.UseCase;
using Sehlea.Api.Domain.Interfaces;
using Sehlea.Api.Domain.Repositories;
using Sehlea.Api.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//dbContext
builder.Services.AddDbContext<AppDbContext>(
req => req.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultSqlServerConnection"))); //al momento de mandar a producción se debe
                                                                               //cambiar esto por una variable de ambiente

//automapper profile
builder.Services.AddAutoMapper(conf =>
{
    conf.AddProfile<AutoMapperProfile>();
});

//interfaces to scoped
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
builder.Services.AddScoped<IConsultasRepository, ConsultaRepository>();
builder.Services.AddScoped<IEstudioMedicoRepository, EstudioMedicosRepository>();
builder.Services.AddScoped<IResultadoEstudioRepository, ResultadoEstudioRepository>();

//useCase
//doctores
builder.Services.AddScoped<AgregarDoctor>();
builder.Services.AddScoped<MostrarDoctores>();
//pacientes
builder.Services.AddScoped<AgregarPaciente>();
builder.Services.AddScoped<MostrarPacientes>();
//consultas
builder.Services.AddScoped<AgregarConsulta>();
builder.Services.AddScoped<BuscarConsulta>();
//estudios-medicos
builder.Services.AddScoped<ConsultarEstudioMedico>();
builder.Services.AddScoped<AgregarEstudioMedico>();
//resultados-estudios-medicos
builder.Services.AddScoped<AgregarResultado>();
builder.Services.AddScoped<ObtenerResultadosPorEstudio>();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler =
        System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
