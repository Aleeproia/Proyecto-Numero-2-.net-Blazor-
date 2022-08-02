using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class EliminarEstudianteUseCase{
    
    private readonly IRepositorioEstudiante _rEstudiante;

    public EliminarEstudianteUseCase(IRepositorioEstudiante _rEstudiante){
        this._rEstudiante=_rEstudiante;
    }
    public void Ejecutar(int Id){
        _rEstudiante.EliminarEstudiante(Id);
    }
}