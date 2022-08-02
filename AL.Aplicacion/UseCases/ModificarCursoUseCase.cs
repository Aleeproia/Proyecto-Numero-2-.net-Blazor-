using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ModificarCursoUseCase{
    private readonly IRepositorioCurso _rCurso;

    public ModificarCursoUseCase(IRepositorioCurso _rCurso){
        this._rCurso=_rCurso;
    }
    public void Ejecutar(int id,Curso curso){
        _rCurso.ModificarCurso(id,curso);
    }
}