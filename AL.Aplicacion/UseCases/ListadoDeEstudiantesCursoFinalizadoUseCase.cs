using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ListadoDeEstudiantesCursoFinalizadoUseCase{


    private readonly IRepositorioEstudiante _rListadoEstudiantes;

    public ListadoDeEstudiantesCursoFinalizadoUseCase(IRepositorioEstudiante _rListadoEstudiantes){
        this._rListadoEstudiantes=_rListadoEstudiantes;
    }

    public List<Listados> Ejecutar(){
        return _rListadoEstudiantes.ListadoEstudianteCursoFinalizado();
    }



}