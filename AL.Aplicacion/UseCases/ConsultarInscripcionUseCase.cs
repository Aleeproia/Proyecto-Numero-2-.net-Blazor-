using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ConsultarInscripcionUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ConsultarInscripcionUseCase(IRepositorioInscripcion _rInscripcion){
        this._rInscripcion=_rInscripcion;
    }
    public Inscripcion? Ejecutar(int idc,int ide){
        return _rInscripcion.ConsultarInscripcion(idc,ide);
    }
}