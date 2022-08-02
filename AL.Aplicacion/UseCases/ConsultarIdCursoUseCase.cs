using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ConsultarIdCursoUseCase{

    private readonly IRepositorioCurso _rCurso;

    public ConsultarIdCursoUseCase(IRepositorioCurso _rCurso){
        this._rCurso=_rCurso;
    }
    public Curso? Ejecutar(int Id){
        return _rCurso.ConsultarIdCurso(Id);
    }

}