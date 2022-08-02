using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class AgregarCursoUseCase{

    private readonly IRepositorioCurso _rCurso;

    public AgregarCursoUseCase(IRepositorioCurso _rCurso){
        this._rCurso=_rCurso;
    }
    public void Ejecutar(Curso curso){
        try{
            _rCurso.AgregarCurso(curso);
        }
        catch
        {
            Console.WriteLine("Genero Excepcion al Agregar un Curso");
        }

    }

}


