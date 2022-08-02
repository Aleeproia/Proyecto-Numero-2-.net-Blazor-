using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Repositorios.RepositorioTP;

public class EntidadContext:DbContext{


    #nullable disable
    public DbSet<Curso> Curso{get;set;}
    public DbSet<Estudiante> Estudiantes{get;set;}
    public DbSet<Inscripcion> inscripciones{get;set;}

    #nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    optionsBuilder.UseSqlite("data source=AL.sqlite");
    }
   



}
