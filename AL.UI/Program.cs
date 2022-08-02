using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using AL.UI.Data;

using AL.Repositorios;
using AL.Aplicacion.UseCases;
using AL.Aplicacion.Interfaces;
using AL.Repositorios.RepositorioTP;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddTransient<GetAllInscripcionesUseCase>();
builder.Services.AddTransient<GetAllCursosUseCase>();
builder.Services.AddTransient<GetAllEstudiantesUseCase>();
builder.Services.AddTransient<AgregarCursoUseCase>();
builder.Services.AddTransient<AgregarEstudianteUseCase>();
builder.Services.AddTransient<AgregarInscripcionUseCase>();
builder.Services.AddTransient<ModificarCursoUseCase>();
builder.Services.AddTransient<ModificarEstudianteUseCase>();
builder.Services.AddTransient<ModificarInscripcionUseCase>();
builder.Services.AddTransient<EliminarCursoUseCase>();
builder.Services.AddTransient<EliminarEstudianteUseCase>();
builder.Services.AddTransient<EliminarInscripcionUseCase>();
builder.Services.AddTransient<ConsultarCursoUseCase>();
builder.Services.AddTransient<ConsultarEstudianteUseCase>();
builder.Services.AddTransient<ConsultarIdCursoUseCase>();
builder.Services.AddTransient<ConsultarIdEstudianteUseCase>();
builder.Services.AddTransient<ConsultarInscripcionUseCase>();
builder.Services.AddTransient<ListadoEstudiantesCursoActualUseCase>();
builder.Services.AddTransient<ListadoDeEstudiantesCursoFinalizadoUseCase>();
builder.Services.AddTransient<ListadoEstudiantesCursosInscriptoUseCase>();
builder.Services.AddTransient<ListadoEstudiantesDadoUnCursoUseCase>();
builder.Services.AddScoped<IRepositorioCurso,RepositorioCursoMock>();
builder.Services.AddScoped<IRepositorioEstudiante,RepositorioEstudianteMock>();
builder.Services.AddScoped<IRepositorioInscripcion,RepositorioInscripcionMock>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
