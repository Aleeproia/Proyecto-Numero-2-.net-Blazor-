using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

public interface IRepositorioEstudiante{


    void AgregarEstudiante(Estudiante est);
    void EliminarEstudiante(int DNI);
    void ModificarEstudiante(int id,Estudiante est);
    Estudiante? ConsultarEstudiante(int DNI);

    Estudiante? ConsultarIdEstudiante(int Id);
    List<Estudiante> GetAllEstudiantes();

    List<Listados> ListadoEstudianteActual();
    List<Listados> ListadoEstudianteCursoFinalizado();
    List<Estudiante> ListadoEstudianteDadoUnCurso(int Id);

    List<Curso> ListarEstudianteCursoInscripto(int Id);

}