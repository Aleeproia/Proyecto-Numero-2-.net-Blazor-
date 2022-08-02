namespace AL.Aplicacion.Entidades;

public class Curso{


    public int Id { get; set; }
    public string? titulo{get;set;}
    public string? descripcion{get;set;}

    public DateTime fechainicio{get;set;}
    public DateTime fechafinalizacion{get;set;}

    public Curso(int Id,string? titulo,string? descripcion,DateTime fechainicio,DateTime fechafinalizacion){
        this.Id=Id;
        this.titulo=titulo;
        this.descripcion=descripcion;
        this.fechainicio=fechainicio;
        this.fechafinalizacion=fechafinalizacion;
    }

    public Curso(){}


    

}