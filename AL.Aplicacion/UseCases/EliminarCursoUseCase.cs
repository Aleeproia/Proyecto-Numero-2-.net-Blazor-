using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class EliminarCursoUseCase{

    private readonly IRepositorioCurso _rCurso;

    public EliminarCursoUseCase(IRepositorioCurso _rCurso){
        this._rCurso=_rCurso;
    }
    public void Ejecutar(int Id){
        _rCurso.EliminarCurso(Id);
    }

}