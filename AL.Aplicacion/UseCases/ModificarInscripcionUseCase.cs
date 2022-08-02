using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ModificarInscripcionUseCase{

    private readonly IRepositorioInscripcion _rInscripcion;

    public ModificarInscripcionUseCase(IRepositorioInscripcion _rInscripcion){
        this._rInscripcion=_rInscripcion;
    }
    public void Ejecutar(int id,Inscripcion i){
        _rInscripcion.ModificarInscripcion(id,i);
    }
}