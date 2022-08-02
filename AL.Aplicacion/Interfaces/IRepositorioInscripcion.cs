using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

public interface IRepositorioInscripcion{


    void AgregarInscripcion(Inscripcion i);
    void EliminarInscripcion(int Id);
    void ModificarInscripcion(int id,Inscripcion i);
    Inscripcion? ConsultarInscripcion(int idc,int ide);

    List<Inscripcion> GetAllInscripciones();


}