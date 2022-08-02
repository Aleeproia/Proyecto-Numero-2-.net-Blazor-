using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

public interface IRepositorioCurso{

    void AgregarCurso(Curso cur);
    void EliminarCurso(int Id);
    void ModificarCurso(int id,Curso cur);
    Curso? ConsultarCurso(string? titulo);
    Curso? ConsultarIdCurso(int Id);
    List<Curso> GetAllCursos();

}