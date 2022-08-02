using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ConsultarEstudianteUseCase{

    private readonly IRepositorioEstudiante _rEstudiante;

    public ConsultarEstudianteUseCase(IRepositorioEstudiante _rEstudiante){
        this._rEstudiante=_rEstudiante;
    }
    public Estudiante? Ejecutar(int DNI){
        return _rEstudiante.ConsultarEstudiante(DNI);
    }

}