using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class EliminarInscripcionUseCase{

    private readonly IRepositorioInscripcion _rInscripcion;

    public EliminarInscripcionUseCase(IRepositorioInscripcion _rInscripcion){
        this._rInscripcion=_rInscripcion;
    }
    public void Ejecutar(int DNI){
        _rInscripcion.EliminarInscripcion(DNI);
    }
    
}