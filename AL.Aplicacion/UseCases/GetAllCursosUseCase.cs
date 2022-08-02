using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class GetAllCursosUseCase{

    private readonly IRepositorioCurso _rGetCursos;

    public GetAllCursosUseCase(IRepositorioCurso _rGetCursos){
        this._rGetCursos=_rGetCursos;
    }

    public List<Curso> Ejecutar(){
        return _rGetCursos.GetAllCursos();
    }

}