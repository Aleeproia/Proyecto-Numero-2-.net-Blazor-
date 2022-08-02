using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ModificarEstudianteUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ModificarEstudianteUseCase(IRepositorioEstudiante _rEstudiante){
        this._rEstudiante=_rEstudiante;
    }
    public void Ejecutar(int id,Estudiante est){
        _rEstudiante.ModificarEstudiante(id,est);
    }
}