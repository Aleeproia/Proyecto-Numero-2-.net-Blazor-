using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ConsultarCursoUseCase{

    private readonly IRepositorioCurso _rCurso;

    public ConsultarCursoUseCase(IRepositorioCurso _rCurso){
        this._rCurso=_rCurso;
    }
    public Curso? Ejecutar(string? titulo_cur){
        return _rCurso.ConsultarCurso(titulo_cur);
    }

}