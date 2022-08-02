namespace AL.Aplicacion.Entidades;

public class Estudiante{

    public int Id { get; set; }
    public string? nombre {get;set;}
    public string? apellido {get;set;}
    public string? email {get;set;}
    public int DNI {get;set;}

    public Estudiante(int Id,string? nombre,string? apellido,string?email,int DNI){
        this.Id=Id;
        this.nombre=nombre;
        this.apellido=apellido;
        this.email=email;
        this.DNI=DNI;

    }
    public Estudiante(){}
}