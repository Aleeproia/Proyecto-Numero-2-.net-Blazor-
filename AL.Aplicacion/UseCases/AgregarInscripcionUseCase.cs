using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class AgregarInscripcionUseCase{

    private readonly IRepositorioInscripcion _rInscripcion;

    public AgregarInscripcionUseCase(IRepositorioInscripcion _rInscripcion){
        this._rInscripcion=_rInscripcion;
    }
    public void Ejecutar(Inscripcion i){
        try{
        _rInscripcion.AgregarInscripcion(i);
        }
        catch{
            Console.WriteLine("Error al agregar una Inscripcion");
        }
    }

}