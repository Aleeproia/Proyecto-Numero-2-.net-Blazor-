using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ConsultarIdEstudianteUseCase{

    private readonly IRepositorioEstudiante _rEstudiante;

    public ConsultarIdEstudianteUseCase(IRepositorioEstudiante _rEstudiante){
        this._rEstudiante=_rEstudiante;
    }
    public Estudiante? Ejecutar(int Id){
        return _rEstudiante.ConsultarIdEstudiante(Id);
    }

}