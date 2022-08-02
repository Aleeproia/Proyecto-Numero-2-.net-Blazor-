using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class AgregarEstudianteUseCase{

    private readonly IRepositorioEstudiante _rEstudiante;

    public AgregarEstudianteUseCase(IRepositorioEstudiante _rEstudiante){
        this._rEstudiante=_rEstudiante;
    }
    public void Ejecutar(Estudiante est){ 
        try{
        _rEstudiante.AgregarEstudiante(est);
        }
        catch{
            Console.WriteLine("Error al Agregar Estudiante");
        }
    }
}