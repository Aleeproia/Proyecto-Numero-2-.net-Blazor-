using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ListadoEstudiantesCursosInscriptoUseCase{

    private readonly IRepositorioEstudiante _rListadoEstudiantes;

    public ListadoEstudiantesCursosInscriptoUseCase(IRepositorioEstudiante _rListadoEstudiantes){
        this._rListadoEstudiantes=_rListadoEstudiantes;
    }

    public List<Curso> Ejecutar(int Id){
        return _rListadoEstudiantes.ListarEstudianteCursoInscripto(Id);
    }

}
