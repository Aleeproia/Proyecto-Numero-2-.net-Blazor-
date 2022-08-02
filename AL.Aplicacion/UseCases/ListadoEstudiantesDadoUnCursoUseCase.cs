using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ListadoEstudiantesDadoUnCursoUseCase{


    private readonly IRepositorioEstudiante _rListadoEstudiantes;

    public ListadoEstudiantesDadoUnCursoUseCase(IRepositorioEstudiante _rListadoEstudiantes){
        this._rListadoEstudiantes=_rListadoEstudiantes;
    }

    public List<Estudiante> Ejecutar(int Id){
        return _rListadoEstudiantes.ListadoEstudianteDadoUnCurso(Id);
    }
}